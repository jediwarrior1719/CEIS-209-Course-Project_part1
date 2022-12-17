using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Johnston_CourseProject_Part1
{
    public partial class MainForm : Form
    {
        // class level references
        string[] titleArray = new string[5];
        string[] artistArray = new string[5];
        string[] genreArray = new string[5];
        int[] yearArray = new int[5];
        string[] urlArray = new string[5];
        int songCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool ValidInput()
        {
            // Return true if all fields are non-empty
            bool isValid = true;
            if (string.IsNullOrEmpty(titleText.Text))
            {
                // Title is blank 
                MessageBox.Show("The song title cannot be blank!");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                // Artist is Blank
                MessageBox.Show("Artist can not be empty!");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(genreText.Text))
            {
                // Artist is Blank
                MessageBox.Show("Genre can not be empty!");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                // Artist is Blank
                MessageBox.Show("Year can not be empty!");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(urlText.Text))
            {
                // Artist is Blank
                MessageBox.Show("URL can not be empty!");
                isValid = false;
            }

            return isValid;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string nl = "\r\n";


            if (ValidInput())
            {
                // Add title to Listbox and song list
                songList.Items.Add(titleText.Text);
                titleArray[songCount] = titleText.Text;
                artistArray[songCount] = artistText.Text;
                genreArray[songCount] = genreText.Text;
                yearArray[songCount] = int.Parse(yearText.Text);
                urlArray[songCount] = urlText.Text;

                // increment the song counter
                songCount++;

                // Build the output text
                sb.Append(titleText.Text);
                sb.Append(nl);
                sb.Append(artistText.Text);
                sb.Append(nl);
                sb.Append(genreText.Text);
                sb.Append(nl);
                sb.Append(yearText.Text);
                sb.Append(nl);
                sb.Append(urlText.Text);
                sb.Append(nl);
                sb.Append(nl);      // blank line

                outputText.Text = sb.ToString();
            }

        }

        private bool SongInList(string songTitle)
        {
            bool found = false;
            foreach (var item in songList.Items)
            {
                string currentSong = item as string;
                // lowercase comparison so not case sensitive 
                if ( songTitle.ToLower() == currentSong.ToLower() )
                {
                    found = true; 
                }
            }
            return found; 
        }
        private int GetSongIndex(string songTitle)
        {
            int songIndex = songList.Items.IndexOf(songTitle);
            return songIndex;
        }



        private void allSongsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string nl = "\r\n";

            // Build the output text 
            foreach(var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(nl);
            }

            // Put the output text into the output textbox
            outputText.Text = sb.ToString();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if(SongInList(titleText.Text))
            {
                StringBuilder sb = new StringBuilder(string.Empty);
                string nl = "\r\n";

                int songIndex = GetSongIndex(titleText.Text);

                // Build the output text 
                sb.Append(titleArray[songIndex]);
                sb.Append(nl);
                sb.Append(artistArray[songIndex]);
                sb.Append(nl);
                sb.Append(genreArray[songIndex]);
                sb.Append(nl);
                sb.Append(yearArray[songIndex]);
                sb.Append(nl);
                sb.Append(urlArray[songIndex]);
                sb.Append(nl);

                outputText.Text = sb.ToString();


            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            titleText.Text = ""; // one way to clear textbox
            artistText.Text = String.Empty; // second way to clear
            genreText.Clear();       // Third way to clear
            yearText.Text = String.Empty;
            urlText.Clear();


        }



        private void webViewDisplay_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex;
            string url = urlArray[songIndex];
            webViewDisplay.CoreWebView2.Navigate(url);
        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex; 

            // If song is selected (index greater than -1), show the details
            if (songIndex > -1)
            {
                StringBuilder sb = new StringBuilder(string.Empty);
                string nl = "\r\n";
                // Build the output text 
                sb.Append(titleArray[songIndex]);
                sb.Append(nl);
                sb.Append(artistArray[songIndex]);
                sb.Append(nl);
                sb.Append(genreArray[songIndex]);
                sb.Append(nl);
                sb.Append(yearArray[songIndex]);
                sb.Append(nl);
                sb.Append(urlArray[songIndex]);
                sb.Append(nl);

                outputText.Text = sb.ToString();

            }

        }
    }
}
