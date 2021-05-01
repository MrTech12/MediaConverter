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
            ExtractAudio(audioCB.GetItemText(audioCB.SelectedItem));
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
            filePaths.Clear();
            fileNames.Clear();
            filesListView.Items.Clear();
        }
    }
}
