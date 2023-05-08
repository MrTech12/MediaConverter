using BusinessLogicLayer.Audio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaConverter
{
    public partial class MediaConverter : Form
    {
        List<IAudioType> selectedAudioTypes = new List<IAudioType>();
        List<string> filePaths = new List<string>();
        List<string> fileNames = new List<string>();
        List<string> fileTypes = new List<string>() { "wav", "mp3", "m4a", "avi", "mov", "mp4", "WAV", "MP3", "M4A", "AVI", "MOV", "MP4" };

        OpenFileDialog fileDialog = new OpenFileDialog();

        public MediaConverter()
        {
            InitializeComponent();
        }

        //TODO: add ability to detect more media filetypes.
        public void GetSelectedFiles()
        {
            fileDialog.Filter = "All Media Files|*.wav;*.mp3;*.m4a;*.avi;*.mov;*.mp4;*.WAV;*.MP3;*.M4A;*.AVI;*.MOV;*.MP4;";
            fileDialog.Multiselect = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileNames.Length != 0)
                {
                    filePaths = fileDialog.FileNames.ToList();
                }

                foreach (var item in filePaths)
                {
                    fileNames = fileDialog.SafeFileNames.ToList();
                }
            }
        }

        private void ShowFileNames()
        {
            foreach (var item in fileNames)
            {
                filesListView.Items.Add(item);
            }
        }

        public void ConvertFile(string convertOption)
        {
            if (IsUserInputValid())
            {
                if (convertOption.Contains("wav"))
                {
                    selectedAudioTypes.Add(new AudioTypeWAV());
                }
                else if (convertOption.Contains("mp3"))
                {
                    selectedAudioTypes.Add(new AudioTypeMP3());
                }

                AudioFileHandling audioFileHandling = new AudioFileHandling(filePaths, selectedAudioTypes);
                audioFileHandling.ChangeFiletype();
                audioFileHandling.CreateNewFile();

                ClearFileLists();
                MessageBox.Show("Conversion completed. The files are stored in your 'Downloads' folder.");
            }
        }

        public bool IsUserInputValid()
        {
            if (filesListView.Items.Count == 0)
            {
                MessageBox.Show("No files selected.");
                return false;
            }
            else if (convertOptionCB.SelectedIndex < 0)
            {
                MessageBox.Show("No convertion option selected.");
                return false;
            }
            return true;
        }

        public void ClearFileLists()
        {
            filePaths.Clear();
            fileNames.Clear();
            filesListView.Items.Clear();
            selectedAudioTypes.Clear();
        }

        private void selectFolderBT_Click(object sender, EventArgs e)
        {
            GetSelectedFiles();
            ShowFileNames();
        }

        private void convertBT_Click(object sender, EventArgs e)
        {
            ConvertFile(convertOptionCB.GetItemText(convertOptionCB.SelectedItem));
        }

        private void clearListBT_Click(object sender, EventArgs e)
        {
            ClearFileLists();
        }
    }
}
