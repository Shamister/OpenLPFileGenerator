using Google.Cloud.Translation.V2;

namespace OpenLPFileGenerator
{
    public class Translator
    {
        public string API_KEY = "API_KEY_HERE";
        public TranslationClient client;

        public Translator()
        {
            client = TranslationClient.CreateFromApiKey(API_KEY);
        }

        public async Task<string> Translate(string text, string fromLanguage, string toLanguage)
        {
            string resultString = string.Empty;
            try
            {
                TranslationResult result = await client.TranslateTextAsync(text, toLanguage, fromLanguage);

                resultString = result.TranslatedText;

            }
            catch (Exception e)
            {

            }

            return resultString;
        }

        public async Task<IList<string>> Translate(IList<string> textList, string fromLanguage, string toLanguage)
        {
            IList<string> resultStrings = new List<string>();
            try
            {
                IList<TranslationResult> results = await client.TranslateTextAsync(textList, toLanguage, fromLanguage);

                resultStrings = results.Select(x => x.TranslatedText).ToList();

            }
            catch (Exception e)
            {

            }

            return resultStrings;
        }

        public async Task<string> DetectLanguage(string text)
        {
            try
            {
                Detection detection = await client.DetectLanguageAsync(text);

                return detection.Language;

            }
            catch (Exception e)
            {

            }

            return LanguageCodes.Indonesian;
        }
    }
}
