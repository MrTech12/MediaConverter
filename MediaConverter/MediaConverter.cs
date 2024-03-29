﻿using BusinessLogicLayer.Audio;
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

        OpenFileDialog fileDialog = new OpenFileDialog();

        public MediaConverter()
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
            if (!CheckEmptyInput())
            {
                if (filetype == "wav")
                {
                    selectedAudioTypes.Add(new AudioTypeWAV());
                }
                else if (filetype == "mp3")
                {
                    selectedAudioTypes.Add(new AudioTypeMP3());
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
