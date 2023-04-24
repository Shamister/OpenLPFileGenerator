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

        public async Task<string> Translate(string text)
        {
            string resultString = string.Empty;
            try
            {
                TranslationResult result = await client.TranslateTextAsync(text, LanguageCodes.English, LanguageCodes.Indonesian);

                resultString = result.TranslatedText;

            }
            catch (Exception e)
            {

            }

            return resultString;
        }

        public async Task<IList<string>> Translate(IList<string> textList)
        {
            IList<string> resultStrings = new List<string>();
            try
            {
                IList<TranslationResult> results = await client.TranslateTextAsync(textList, LanguageCodes.English, LanguageCodes.Indonesian);

                resultStrings = results.Select(x => x.TranslatedText).ToList();

            }
            catch (Exception e)
            {

            }

            return resultStrings;
        }
    }
}
