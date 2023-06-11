using System.Reflection;
using System.Text.RegularExpressions;

namespace OpenLPFileGenerator
{
    public partial class Form1 : Form
    {
        private readonly string SongTitlePattern = @"^[a-zA-Z0-9 ,.!()]+$";

        public Form1()
        {
            InitializeComponent();

            var version = Assembly.GetExecutingAssembly().GetName().Version;

            VersionLabel.Text = version?.ToString();
        }

        private async void Generate_Click(object sender, EventArgs e)
        {
            // check if song title meets the requirement
            Match m = Regex.Match(songTitleTextBox.Text, SongTitlePattern, RegexOptions.IgnoreCase);

            if (string.IsNullOrWhiteSpace(songTitleTextBox.Text))
            {
                MessageBox.Show("Please fill the song title.");
            }
            else if (!m.Success)
            {
                MessageBox.Show("Please fill the song title with alphanumeric only.");
            }
            else if (string.IsNullOrWhiteSpace(lyricsTextBox.Text))
            {
                MessageBox.Show("Please add some lyrics, minimum 1 line.");
            }
            else if (string.IsNullOrWhiteSpace(outputDirectoryTextBox.Text))
            {
                MessageBox.Show("Please select the output directory.");
            }
            else
            {
                Parameters parameters = new Parameters();
                parameters.Title = songTitleTextBox.Text;
                parameters.MaxLines = Convert.ToInt32(linePerSlideNumber.Value);
                parameters.OutputDirectory = outputDirectoryTextBox.Text;
                parameters.AutoTranslate = autoTranslateCheckBox.Checked;
                parameters.BracketBetweenTranslation = bracketBetweenTranslationCheckBox.Checked;
                parameters.LineBreaksBetweenTranslation = Convert.ToInt32(lineBreaksBetweenTranslationNumber.Value);

                ProgressManager manager = new ProgressManager(progressBar1);

                Generator openLPGenerator = new Generator(lyricsTextBox.Text, parameters, manager);

                var isGenerated = await Task.Run(() =>
                {
                    return openLPGenerator.GenerateOpenLPXMLFile();
                });

                if (isGenerated)
                {
                    MessageBox.Show("The file has been generated.");
                }
                else
                {
                    MessageBox.Show("Something wrong when generating the file.");
                };
            }
        }

        private void browseDirectoryButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                outputDirectoryTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}