namespace OpenLPFileGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            songTitleTextBox = new TextBox();
            label2 = new Label();
            lyricsTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            browseDirectoryButton = new Button();
            outputDirectoryTextBox = new TextBox();
            Generate = new Button();
            linePerSlideNumber = new NumericUpDown();
            VersionLabel = new Label();
            autoTranslateCheckBox = new CheckBox();
            lineBreaksBetweenTranslationNumber = new NumericUpDown();
            label7 = new Label();
            bracketBetweenTranslationCheckBox = new CheckBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)linePerSlideNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineBreaksBetweenTranslationNumber).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(17, 71);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Song Title*";
            // 
            // songTitleTextBox
            // 
            songTitleTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            songTitleTextBox.Location = new Point(134, 66);
            songTitleTextBox.Name = "songTitleTextBox";
            songTitleTextBox.Size = new Size(495, 29);
            songTitleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 9);
            label2.Name = "label2";
            label2.Size = new Size(254, 32);
            label2.TabIndex = 2;
            label2.Text = "OpenLP File Generator";
            // 
            // lyricsTextBox
            // 
            lyricsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lyricsTextBox.Location = new Point(23, 152);
            lyricsTextBox.Multiline = true;
            lyricsTextBox.Name = "lyricsTextBox";
            lyricsTextBox.ScrollBars = ScrollBars.Both;
            lyricsTextBox.Size = new Size(606, 372);
            lyricsTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 119);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 4;
            label3.Text = "Lyrics";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(651, 252);
            label4.Name = "label4";
            label4.Size = new Size(223, 17);
            label4.TabIndex = 5;
            label4.Text = "Max. lines per slide (excl. translation)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(646, 152);
            label5.Name = "label5";
            label5.Size = new Size(105, 17);
            label5.TabIndex = 6;
            label5.Text = "Output Directory";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(646, 119);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 7;
            label6.Text = "Settings";
            // 
            // browseDirectoryButton
            // 
            browseDirectoryButton.Location = new Point(984, 190);
            browseDirectoryButton.Name = "browseDirectoryButton";
            browseDirectoryButton.Size = new Size(36, 23);
            browseDirectoryButton.TabIndex = 8;
            browseDirectoryButton.Text = ". . .";
            browseDirectoryButton.UseVisualStyleBackColor = true;
            browseDirectoryButton.Click += browseDirectoryButton_Click;
            // 
            // outputDirectoryTextBox
            // 
            outputDirectoryTextBox.Location = new Point(651, 190);
            outputDirectoryTextBox.Name = "outputDirectoryTextBox";
            outputDirectoryTextBox.Size = new Size(321, 23);
            outputDirectoryTextBox.TabIndex = 9;
            // 
            // Generate
            // 
            Generate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Generate.Location = new Point(651, 389);
            Generate.Name = "Generate";
            Generate.Size = new Size(369, 74);
            Generate.TabIndex = 11;
            Generate.Text = "Generate!";
            Generate.UseVisualStyleBackColor = true;
            Generate.Click += Generate_Click;
            // 
            // linePerSlideNumber
            // 
            linePerSlideNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linePerSlideNumber.Location = new Point(880, 250);
            linePerSlideNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            linePerSlideNumber.Name = "linePerSlideNumber";
            linePerSlideNumber.Size = new Size(50, 25);
            linePerSlideNumber.TabIndex = 12;
            linePerSlideNumber.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // VersionLabel
            // 
            VersionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(984, 534);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(45, 15);
            VersionLabel.TabIndex = 13;
            VersionLabel.Text = "Version";
            // 
            // autoTranslateCheckBox
            // 
            autoTranslateCheckBox.AutoSize = true;
            autoTranslateCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            autoTranslateCheckBox.Location = new Point(654, 308);
            autoTranslateCheckBox.Name = "autoTranslateCheckBox";
            autoTranslateCheckBox.Size = new Size(337, 21);
            autoTranslateCheckBox.TabIndex = 14;
            autoTranslateCheckBox.Text = "Translate to English/Indonesian (by Google Translate)";
            autoTranslateCheckBox.UseVisualStyleBackColor = true;
            // 
            // lineBreaksBetweenTranslationNumber
            // 
            lineBreaksBetweenTranslationNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lineBreaksBetweenTranslationNumber.Location = new Point(849, 340);
            lineBreaksBetweenTranslationNumber.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            lineBreaksBetweenTranslationNumber.Name = "lineBreaksBetweenTranslationNumber";
            lineBreaksBetweenTranslationNumber.Size = new Size(50, 25);
            lineBreaksBetweenTranslationNumber.TabIndex = 15;
            lineBreaksBetweenTranslationNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(651, 342);
            label7.Name = "label7";
            label7.Size = new Size(192, 17);
            label7.TabIndex = 16;
            label7.Text = "Line breaks between translation";
            // 
            // bracketBetweenTranslationCheckBox
            // 
            bracketBetweenTranslationCheckBox.AutoSize = true;
            bracketBetweenTranslationCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bracketBetweenTranslationCheckBox.Location = new Point(654, 281);
            bracketBetweenTranslationCheckBox.Name = "bracketBetweenTranslationCheckBox";
            bracketBetweenTranslationCheckBox.Size = new Size(216, 21);
            bracketBetweenTranslationCheckBox.TabIndex = 17;
            bracketBetweenTranslationCheckBox.Text = "Add bracket between translation";
            bracketBetweenTranslationCheckBox.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Enabled = false;
            progressBar1.Location = new Point(651, 480);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(369, 23);
            progressBar1.TabIndex = 18;
            progressBar1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 561);
            Controls.Add(progressBar1);
            Controls.Add(bracketBetweenTranslationCheckBox);
            Controls.Add(label7);
            Controls.Add(lineBreaksBetweenTranslationNumber);
            Controls.Add(autoTranslateCheckBox);
            Controls.Add(VersionLabel);
            Controls.Add(linePerSlideNumber);
            Controls.Add(Generate);
            Controls.Add(outputDirectoryTextBox);
            Controls.Add(browseDirectoryButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lyricsTextBox);
            Controls.Add(label2);
            Controls.Add(songTitleTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "OpenLP File Generator";
            ((System.ComponentModel.ISupportInitialize)linePerSlideNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineBreaksBetweenTranslationNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox songTitleTextBox;
        private Label label2;
        private TextBox lyricsTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button browseDirectoryButton;
        private TextBox outputDirectoryTextBox;
        private Button Generate;
        private NumericUpDown linePerSlideNumber;
        private Label VersionLabel;
        private CheckBox autoTranslateCheckBox;
        private NumericUpDown lineBreaksBetweenTranslationNumber;
        private Label label7;
        private CheckBox bracketBetweenTranslationCheckBox;
        private ProgressBar progressBar1;
    }
}