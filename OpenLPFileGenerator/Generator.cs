using Google.Cloud.Translation.V2;
using System.Text.RegularExpressions;

namespace OpenLPFileGenerator
{
    /**
     * a Generator class that accepts a string of lyrics and a parameter object
     * Output the OpenLP XML file into a directory with the filename specified.
     */
    public class Generator
    {
        private readonly string XMLTag = "<?xml version='1.0' encoding='UTF-8'?>";
        private readonly string DefaultSlidePrefix = "Slide";
        private readonly string BreakPattern = @"^\[break\]";
        private readonly string SkipPattern = @"^\[skip\]";
        private readonly string SlideNameOverridePattern = @"^\[:\w*.*\]";

        private string _lyrics;
        private string _outputDirectory;
        private string _title;
        private int _maxLines;
        private bool _autoTranslate;
        private bool _bracketBetweenTranslation;
        private int _lineBreaksBetweenTranslation;

        private Translator translator;
        private ProgressManager _progressManager;

        public Generator(string lyrics, Parameters parameters, ProgressManager progressManager)
        {
            _lyrics = lyrics;
            _outputDirectory = parameters.OutputDirectory;
            _title = parameters.Title;
            _maxLines = parameters.MaxLines;
            _autoTranslate = parameters.AutoTranslate;
            _bracketBetweenTranslation = parameters.BracketBetweenTranslation;
            _lineBreaksBetweenTranslation = parameters.LineBreaksBetweenTranslation;
            _progressManager = progressManager;

            translator = new Translator();
        }

        public bool GenerateOpenLPXMLFile()
        {
            try
            {
                // start the progress bar
                _progressManager.Start();

                string xml = XMLTag + Environment.NewLine + GenerateSongTag();
                using (StreamWriter sw = new StreamWriter(Path.Combine(_outputDirectory, _title + ".xml")))
                {
                    sw.WriteLine(xml);
                }

                _progressManager.Complete();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public string GenerateSongTag()
        {
            string text = "<song>" + Environment.NewLine;

            text += GeneratePropertiesTag() + Environment.NewLine;
            text += GenerateLyricsTag() + Environment.NewLine;

            text += "</song>";

            return text;
        }

        public string GeneratePropertiesTag()
        {
            // progress +10%
            _progressManager.IncreaseValue(10);

            return @"<properties>
                <titles>
                <title>" +
                _title +
                @"</title>
                </titles>
                </properties>";
        }

        public string GenerateLyricsTag()
        {
            string text = "<lyrics>" + Environment.NewLine;
            string slidePrefix = DefaultSlidePrefix;

            int slideCounter = 0;
            int lineCounter = 0;
            bool openTag = false;

            string[] lines = _lyrics.Split(Environment.NewLine);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                if (IsSkip(line))
                {
                    if (openTag)
                    {
                        text += GetClosingVerseTag();
                        slideCounter++;
                        text += GetOpeningVerseTag(slidePrefix, slideCounter);
                    }
                    lineCounter = 0;
                    continue;
                }

                if (IsSlideNameOverride(line))
                {
                    if (openTag)
                    {
                        text += GetClosingVerseTag();
                    }

                    slideCounter = 1;
                    slidePrefix = GetSlideNamefromOverride(line);

                    text += GetOpeningVerseTag(slidePrefix, slideCounter);
                    lineCounter = 0;
                    openTag = true;

                    continue;
                }

                if (lineCounter >= _maxLines)
                {
                    if (openTag)
                    {
                        text += GetClosingVerseTag();
                    }
                    GoToNextSlide(ref slidePrefix, ref text, ref slideCounter, ref lineCounter, ref openTag);

                    AddWords(line, ref text, ref lineCounter);
                }
                else
                {
                    if (!openTag)
                    {
                        GoToNextSlide(ref slidePrefix, ref text, ref slideCounter, ref lineCounter, ref openTag);
                    }

                    AddWords(line, ref text, ref lineCounter);
                }

                // progress +percent/80%
                _progressManager.IncreaseValue(80D / lines.Length);
            }

            if (openTag)
            {
                text += GetClosingVerseTag();
            }


            text += "</lyrics>";

            return text;
        }


        #region Helper Functions

        public void AddWords(string words, ref string text, ref int lineCounter)
        {
            if (IsLineBreak(words))
            {
                text += Environment.NewLine;
            }
            else
            {
                text += words + Environment.NewLine;

                if (_autoTranslate)
                {
                    string fromLanguage = LanguageCodes.Indonesian;
                    string toLanguage = LanguageCodes.English;

                    string textLanguage = translator.DetectLanguage(words).Result;

                    if (textLanguage != null && textLanguage.Equals(toLanguage))
                    {
                        toLanguage = fromLanguage;
                        fromLanguage = textLanguage;
                    }

                    var translated = translator.Translate(words, fromLanguage, toLanguage).Result;

                    if (translated == null)
                    {
                        throw new Exception("Something wrong with translation API.");
                    }

                    for (int i = 0; i < _lineBreaksBetweenTranslation; i++)
                    {
                        text += Environment.NewLine;
                    }

                    if (_bracketBetweenTranslation)
                    {
                        text += "(";
                    }

                    text += translated;

                    if (_bracketBetweenTranslation)
                    {
                        text += ")";
                    }

                    text += Environment.NewLine;

                    for (int i = 0; i < _lineBreaksBetweenTranslation; i++)
                    {
                        text += Environment.NewLine;
                    }
                }
            }

            lineCounter++;
        }

        public void GoToNextSlide(ref string slidePrefix, ref string text, ref int slideCounter, ref int lineCounter, ref bool openTag)
        {
            slideCounter++;
            text += GetOpeningVerseTag(slidePrefix, slideCounter);
            lineCounter = 0;
            openTag = true;
        }

        public string GetClosingVerseTag()
        {
            return "</lines>" + Environment.NewLine + "</verse>" + Environment.NewLine;
        }

        public string GetOpeningVerseTag(string slidePrefix, int slideCounter)
        {
            return "<verse name=\"" + slidePrefix + " " + slideCounter + "\">" + Environment.NewLine + "<lines>";
        }

        public bool IsLineBreak(string line)
        {
            Match m = Regex.Match(line, BreakPattern, RegexOptions.IgnoreCase);
            return m.Success;
        }

        public bool IsSkip(string line)
        {
            Match m = Regex.Match(line, SkipPattern, RegexOptions.IgnoreCase);
            return m.Success;
        }

        public bool IsSlideNameOverride(string line)
        {
            Match m = Regex.Match(line, SlideNameOverridePattern, RegexOptions.IgnoreCase);
            return m.Success;
        }

        public string GetSlideNamefromOverride(string nameOverride)
        {
            return nameOverride.Substring(2, nameOverride.Length - 3);
        }

        #endregion
    }
}
