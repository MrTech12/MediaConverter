using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace BusinessLogicLayer
{
    public class AudioLogic : FileHandling
    {
        private string[] selectedFiles;
        private List<string> audioFilename = new List<string>();

        public string[] SelectedFiles { get { return this.selectedFiles; } set { this.selectedFiles = value; } }
        public List<string> AudioFilename { get { return this.audioFilename; } set { this.audioFilename = value; } }

        public AudioLogic(string[] selectedFiles)
        {
            this.selectedFiles = selectedFiles;
        }

        //TODO: convert to different audio files, other than mp3.
        public override void CreateNewFilename()
        {
            foreach (var item in this.selectedFiles)
            {
                int index = item.IndexOf(".");
                string filename = item.Substring(0, index) + ".mp3";
                audioFilename.Add(filename);
            }
        }

        public override void CreateNewFile()
        {
            Process process = new Process();
            process.StartInfo.FileName = "ffmpeg.exe";

            for (int i = 0; i < this.selectedFiles.Length; i++)
            {
                process.StartInfo.Arguments = String.Format(@"-i ""{0}"" ""{1}""", this.selectedFiles[i], this.audioFilename[i]);
                process.Start();
                process.WaitForExit();
            }
        }
    }
}
