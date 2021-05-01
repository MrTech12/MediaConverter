using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaManager
{
    public partial class MediaManager : Form
    {
        string[] filePaths;
        List<string> fileNames = new List<string>();

        FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

        public MediaManager()
        {
            InitializeComponent();
        }

        private void selectFolderBT_Click(object sender, EventArgs e)
        {
            GetFileDetails();
            ShowFiles();
        }

        private void extractAudioBT_Click(object sender, EventArgs e)
        {
            ExtractAudio(audioCB.GetItemText(audioCB.SelectedItem));
        }

        private void clearListBT_Click(object sender, EventArgs e)
        {
            ClearFileList();
        }

        //TODO: add ability to detect more media filetypes, other than mp4.
        public void GetFileDetails()
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                filePaths = Directory.GetFiles(folderBrowser.SelectedPath, "*.mp4");

                foreach (var item in filePaths)
                {
                    fileNames.Add(item.Replace(folderBrowser.SelectedPath, String.Empty).Replace(@"\", "")); //Only display the filenames.
                }
            }
        }

        private void ShowFiles()
        {
            foreach (var item in fileNames)
            {
                filesListView.Items.Add(item);
            }
        }

        public void ExtractAudio(string type)
        {
            if (filesListView.Items.Count == 0)
            {
                MessageBox.Show("No files selected.");
            }
            else if(audioCB.SelectedIndex < 0)
            {
                MessageBox.Show("No audio type selected.");
            }
            else
            {
                AudioLogic audioLogic = new AudioLogic(filePaths);
                audioLogic.ChangeFiletype(type);
                audioLogic.CreateNewFile();

                ClearFileList();
                MessageBox.Show("Audio extracted");
            }
        }

        public void ClearFileList()
        {
            Array.Clear(filePaths, 0, filePaths.Length);
            fileNames.Clear();
            filesListView.Items.Clear();
        }
    }
}
