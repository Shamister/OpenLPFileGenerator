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
            this.label1 = new System.Windows.Forms.Label();
            this.songTitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lyricsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browseDirectoryButton = new System.Windows.Forms.Button();
            this.outputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.linePerSlideNumber = new System.Windows.Forms.NumericUpDown();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.autoTranslateCheckBox = new System.Windows.Forms.CheckBox();
            this.lineBreaksBetweenTranslationNumber = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.bracketBetweenTranslationCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.linePerSlideNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBreaksBetweenTranslationNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Song Title*";
            // 
            // songTitleTextBox
            // 
            this.songTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.songTitleTextBox.Location = new System.Drawing.Point(134, 66);
            this.songTitleTextBox.Name = "songTitleTextBox";
            this.songTitleTextBox.Size = new System.Drawing.Size(495, 29);
            this.songTitleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "OpenLP File Generator";
            // 
            // lyricsTextBox
            // 
            this.lyricsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lyricsTextBox.Location = new System.Drawing.Point(23, 152);
            this.lyricsTextBox.Multiline = true;
            this.lyricsTextBox.Name = "lyricsTextBox";
            this.lyricsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lyricsTextBox.Size = new System.Drawing.Size(606, 397);
            this.lyricsTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lyrics";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(651, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Max. lines per slide (excl. translation)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(646, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Output Directory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(646, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Settings";
            // 
            // browseDirectoryButton
            // 
            this.browseDirectoryButton.Location = new System.Drawing.Point(984, 190);
            this.browseDirectoryButton.Name = "browseDirectoryButton";
            this.browseDirectoryButton.Size = new System.Drawing.Size(36, 23);
            this.browseDirectoryButton.TabIndex = 8;
            this.browseDirectoryButton.Text = ". . .";
            this.browseDirectoryButton.UseVisualStyleBackColor = true;
            this.browseDirectoryButton.Click += new System.EventHandler(this.browseDirectoryButton_Click);
            // 
            // outputDirectoryTextBox
            // 
            this.outputDirectoryTextBox.Location = new System.Drawing.Point(651, 190);
            this.outputDirectoryTextBox.Name = "outputDirectoryTextBox";
            this.outputDirectoryTextBox.Size = new System.Drawing.Size(321, 23);
            this.outputDirectoryTextBox.TabIndex = 9;
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Generate.Location = new System.Drawing.Point(651, 416);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(369, 74);
            this.Generate.TabIndex = 11;
            this.Generate.Text = "Generate!";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // linePerSlideNumber
            // 
            this.linePerSlideNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linePerSlideNumber.Location = new System.Drawing.Point(880, 250);
            this.linePerSlideNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.linePerSlideNumber.Name = "linePerSlideNumber";
            this.linePerSlideNumber.Size = new System.Drawing.Size(50, 25);
            this.linePerSlideNumber.TabIndex = 12;
            this.linePerSlideNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(984, 534);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(45, 15);
            this.VersionLabel.TabIndex = 13;
            this.VersionLabel.Text = "Version";
            // 
            // autoTranslateCheckBox
            // 
            this.autoTranslateCheckBox.AutoSize = true;
            this.autoTranslateCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoTranslateCheckBox.Location = new System.Drawing.Point(654, 308);
            this.autoTranslateCheckBox.Name = "autoTranslateCheckBox";
            this.autoTranslateCheckBox.Size = new System.Drawing.Size(347, 21);
            this.autoTranslateCheckBox.TabIndex = 14;
            this.autoTranslateCheckBox.Text = "automatically translate to English (by Google Translate)";
            this.autoTranslateCheckBox.UseVisualStyleBackColor = true;
            // 
            // lineBreaksBetweenTranslationNumber
            // 
            this.lineBreaksBetweenTranslationNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lineBreaksBetweenTranslationNumber.Location = new System.Drawing.Point(849, 340);
            this.lineBreaksBetweenTranslationNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lineBreaksBetweenTranslationNumber.Name = "lineBreaksBetweenTranslationNumber";
            this.lineBreaksBetweenTranslationNumber.Size = new System.Drawing.Size(50, 25);
            this.lineBreaksBetweenTranslationNumber.TabIndex = 15;
            this.lineBreaksBetweenTranslationNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(651, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Line breaks between translation";
            // 
            // bracketBetweenTranslationCheckBox
            // 
            this.bracketBetweenTranslationCheckBox.AutoSize = true;
            this.bracketBetweenTranslationCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bracketBetweenTranslationCheckBox.Location = new System.Drawing.Point(654, 281);
            this.bracketBetweenTranslationCheckBox.Name = "bracketBetweenTranslationCheckBox";
            this.bracketBetweenTranslationCheckBox.Size = new System.Drawing.Size(215, 21);
            this.bracketBetweenTranslationCheckBox.TabIndex = 17;
            this.bracketBetweenTranslationCheckBox.Text = "add bracket between translation";
            this.bracketBetweenTranslationCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.bracketBetweenTranslationCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lineBreaksBetweenTranslationNumber);
            this.Controls.Add(this.autoTranslateCheckBox);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.linePerSlideNumber);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.outputDirectoryTextBox);
            this.Controls.Add(this.browseDirectoryButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lyricsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.songTitleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "OpenLP File Generator";
            ((System.ComponentModel.ISupportInitialize)(this.linePerSlideNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBreaksBetweenTranslationNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}