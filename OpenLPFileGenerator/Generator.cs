using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

        private string lyrics;
        private string outputDirectory;
        private string title;
        private int maxLines;
        private bool autoTranslate;
        private bool bracketBetweenTranslation;
        private int lineBreaksBetweenTranslation;

        private Translator translator;

        public Generator(string lyrics, Parameters parameters)
        {
            this.lyrics = lyrics;
            outputDirectory = parameters.OutputDirectory;
            title = parameters.Title;
            maxLines = parameters.MaxLines;
            autoTranslate = parameters.AutoTranslate;
            bracketBetweenTranslation = parameters.BracketBetweenTranslation;
            lineBreaksBetweenTranslation = parameters.LineBreaksBetweenTranslation;

            translator = new Translator();
        }

        public bool GenerateOpenLPXMLFile()
        {
            try
            {
                string xml = XMLTag + Environment.NewLine + GenerateSongTag();
                using (StreamWriter sw = new StreamWriter(Path.Combine(outputDirectory, title + ".xml")))
                {
                    sw.WriteLine(xml);
                }
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
            return @"<properties>
                <titles>
                <title>" +
                title +
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

            string[] lines = lyrics.Split(Environment.NewLine);
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

                if (lineCounter >= maxLines)
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

                if (autoTranslate)
                {
                    var translated = translator.Translate(words).Result;

                    if (translated == null)
                    {
                        throw new Exception("Something wrong with translation API.");
                    }

                    for (int i = 0; i < lineBreaksBetweenTranslation; i++)
                    {
                        text += Environment.NewLine;
                    }

                    if (bracketBetweenTranslation)
                    {
                        text += "(";
                    }

                    text += translated;

                    if (bracketBetweenTranslation)
                    {
                        text += ")";
                    }

                    text += Environment.NewLine;

                    for (int i = 0; i < lineBreaksBetweenTranslation; i++)
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
