using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace BusinessLogicLayer
{
    public class AudioLogic : FileHandling
    {
        private List<string> selectedFiles = new List<string>();
        private List<string> audioFiles = new List<string>();

        public List<string> SelectedFiles { get { return this.selectedFiles; } set { this.selectedFiles = value; } }
        public List<string> AudioFiles { get { return this.audioFiles; } set { this.audioFiles = value; } }

        public AudioLogic(List<string> selectedFiles)
        {
            this.selectedFiles = selectedFiles;
        }

        //TODO: convert to different audio files, other than mp3.
        public override void ChangeFiletype(string newFiletype)
        {
            foreach (var item in this.selectedFiles)
            {
                int dotIndex = item.IndexOf(".");
                string filename = item.Substring(0, dotIndex);
                if (newFiletype == "wav")
                {
                    filename += ".wav";
                }
                else if (newFiletype == "mp3")
                {
                    filename += ".mp3";
                }
                audioFiles.Add(filename);
            }
        }

        public override void CreateNewFile()
        {
            Process process = new Process();
            process.StartInfo.FileName = "ffmpeg.exe";

            for (int i = 0; i < this.selectedFiles.Count; i++)
            {
                process.StartInfo.Arguments = String.Format(@"-i ""{0}"" ""{1}""", this.selectedFiles[i], this.audioFiles[i]);
                process.Start();
                process.WaitForExit();
            }
        }
    }
}
