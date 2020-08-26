﻿using BusinessLogicLayer;
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
            ExtractAudio();
        }

        private void clearListBT_Click(object sender, EventArgs e)
        {
            ClearCollections();
        }

        public void GetFileDetails()
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                filePaths = Directory.GetFiles(folderBrowser.SelectedPath, "*.mp4");

                foreach (var item in filePaths)
                {
                    fileNames.Add(item.Replace(folderBrowser.SelectedPath, String.Empty).Replace(@"\", ""));
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

        public void ExtractAudio()
        {
            if (filesListView.Items.Count == 0)
            {
                MessageBox.Show("No folder selected.");
            }
            else
            {
                AudioLogic audioLogic = new AudioLogic(filePaths);
                audioLogic.ExtractAudio();

                ClearCollections();

                MessageBox.Show("Audio extracted");
            }
        }

        public void ClearCollections()
        {
            Array.Clear(filePaths, 0, filePaths.Length);
            fileNames.Clear();
            filesListView.Items.Clear();
        }
    }
}
