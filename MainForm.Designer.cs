namespace Johnston_CourseProject_Part1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.songList = new System.Windows.Forms.ListBox();
            this.allSongsButton = new System.Windows.Forms.Button();
            this.songListLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.webViewDisplay = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.PlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(59, 15);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(59, 25);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Title:";
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.Color.Cyan;
            this.titleText.Location = new System.Drawing.Point(135, 12);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(220, 32);
            this.titleText.TabIndex = 0;
            // 
            // artistText
            // 
            this.artistText.BackColor = System.Drawing.Color.Cyan;
            this.artistText.Location = new System.Drawing.Point(135, 77);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(220, 32);
            this.artistText.TabIndex = 1;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(59, 80);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(68, 25);
            this.artistLabel.TabIndex = 2;
            this.artistLabel.Text = "Artist:";
            // 
            // genreText
            // 
            this.genreText.BackColor = System.Drawing.Color.Cyan;
            this.genreText.Location = new System.Drawing.Point(135, 141);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(220, 32);
            this.genreText.TabIndex = 2;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(58, 144);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(71, 25);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Genre:";
            // 
            // yearText
            // 
            this.yearText.BackColor = System.Drawing.Color.Cyan;
            this.yearText.Location = new System.Drawing.Point(135, 204);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(220, 32);
            this.yearText.TabIndex = 3;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(59, 207);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(59, 25);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Year:";
            // 
            // urlText
            // 
            this.urlText.BackColor = System.Drawing.Color.Cyan;
            this.urlText.Location = new System.Drawing.Point(135, 268);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(220, 32);
            this.urlText.TabIndex = 4;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(59, 271);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(59, 25);
            this.urlLabel.TabIndex = 8;
            this.urlLabel.Text = "URL:";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Aqua;
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddButton.Location = new System.Drawing.Point(135, 336);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(174, 54);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "ADD SONG ";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.Cyan;
            this.outputText.Location = new System.Drawing.Point(436, 278);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(317, 314);
            this.outputText.TabIndex = 11;
            this.outputText.TabStop = false;
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // songList
            // 
            this.songList.BackColor = System.Drawing.Color.Cyan;
            this.songList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.ItemHeight = 23;
            this.songList.Location = new System.Drawing.Point(436, 48);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(317, 188);
            this.songList.TabIndex = 12;
            this.songList.TabStop = false;
            this.songList.UseTabStops = false;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.songList_SelectedIndexChanged);
            // 
            // allSongsButton
            // 
            this.allSongsButton.BackColor = System.Drawing.Color.Aqua;
            this.allSongsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.allSongsButton.Location = new System.Drawing.Point(135, 396);
            this.allSongsButton.Name = "allSongsButton";
            this.allSongsButton.Size = new System.Drawing.Size(174, 58);
            this.allSongsButton.TabIndex = 6;
            this.allSongsButton.Text = "SHOW ALL SONGS";
            this.allSongsButton.UseVisualStyleBackColor = false;
            this.allSongsButton.Click += new System.EventHandler(this.allSongsButton_Click);
            // 
            // songListLabel
            // 
            this.songListLabel.AutoSize = true;
            this.songListLabel.Location = new System.Drawing.Point(431, 15);
            this.songListLabel.Name = "songListLabel";
            this.songListLabel.Size = new System.Drawing.Size(100, 25);
            this.songListLabel.TabIndex = 14;
            this.songListLabel.Text = "Song List:";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(431, 250);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(81, 25);
            this.detailsLabel.TabIndex = 15;
            this.detailsLabel.Text = "Details:";
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.Aqua;
            this.findButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findButton.Location = new System.Drawing.Point(135, 460);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(174, 58);
            this.findButton.TabIndex = 16;
            this.findButton.Text = "FIND SONG";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Aqua;
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearButton.Location = new System.Drawing.Point(135, 524);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(174, 58);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // webViewDisplay
            // 
            this.webViewDisplay.AllowExternalDrop = true;
            this.webViewDisplay.CreationProperties = null;
            this.webViewDisplay.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewDisplay.Location = new System.Drawing.Point(783, 48);
            this.webViewDisplay.Name = "webViewDisplay";
            this.webViewDisplay.Size = new System.Drawing.Size(568, 364);
            this.webViewDisplay.Source = new System.Uri("https://www.youtube.com", System.UriKind.Absolute);
            this.webViewDisplay.TabIndex = 18;
            this.webViewDisplay.ZoomFactor = 1D;
            this.webViewDisplay.Click += new System.EventHandler(this.webViewDisplay_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Aqua;
            this.PlayButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayButton.Location = new System.Drawing.Point(783, 526);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(174, 54);
            this.PlayButton.TabIndex = 19;
            this.PlayButton.TabStop = false;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1363, 615);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.webViewDisplay);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.songListLabel);
            this.Controls.Add(this.allSongsButton);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.textLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Video Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button allSongsButton;
        private System.Windows.Forms.Label songListLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button clearButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDisplay;
        private System.Windows.Forms.Button PlayButton;
    }
}

