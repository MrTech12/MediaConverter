using BusinessLogicLayer.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MediaManager
{
    public partial class MediaManager : Form
    {
        List<AudioType> selectedAudioTypes = new List<AudioType>();
        List<string> filePaths = new List<string>();
        List<string> fileNames = new List<string>();

        OpenFileDialog fileDialog = new OpenFileDialog();

        public MediaManager()
        {
            InitializeComponent();
        }

        private void selectFolderBT_Click(object sender, EventArgs e)
        {
            GetSelectedFile();
            ShowFileName();
        }

        private void extractAudioBT_Click(object sender, EventArgs e)
        {
            ExtractAudio(audioFiletypeCB.GetItemText(audioFiletypeCB.SelectedItem));
        }

        private void clearListBT_Click(object sender, EventArgs e)
        {
            ClearFileList();
        }

        //TODO: add ability to detect more media filetypes.
        public void GetSelectedFile()
        {
            fileDialog.Filter = "All Media Files|*.wav;*.mp3;*.avi;*.mov;*.mp4;*.WAV;*.MP3;*.AVI;*.MOV;*.MP4;";
            fileDialog.Multiselect = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileNames.Length != 0)
                {
                    filePaths = fileDialog.FileNames.ToList();
                }

                foreach (var item in filePaths)
                {
                    fileNames = fileDialog.SafeFileNames.ToList(); //Storing only the filenames, not the full path.
                }
            }
        }

        private void ShowFileName()
        {
            foreach (var item in fileNames)
            {
                filesListView.Items.Add(item);
            }
        }

        public void ExtractAudio(string filetype)
        {
            if(!CheckEmptyInput())
            {
                if (filetype == "wav")
                {
                    selectedAudioTypes.Add(new TypeWAV());
                }
                else if (filetype == "mp3")
                {
                    selectedAudioTypes.Add(new TypeMP3());
                }
                AudioFileHandling audioFileHandling = new AudioFileHandling(filePaths, selectedAudioTypes);
                audioFileHandling.ChangeFiletype();
                audioFileHandling.CreateNewFile();

                ClearFileList();
                MessageBox.Show("Audio extracted.");
            }
        }

        public bool CheckEmptyInput()
        {
            if (filesListView.Items.Count == 0)
            {
                MessageBox.Show("No files selected.");
                return true;
            }
            else if (audioFiletypeCB.SelectedIndex < 0)
            {
                MessageBox.Show("No audio type selected.");
                return true;
            }
            return false;
        }

        public void ClearFileList()
        {
            filePaths.Clear();
            fileNames.Clear();
            filesListView.Items.Clear();
            selectedAudioTypes.Clear();
        }
    }
}
