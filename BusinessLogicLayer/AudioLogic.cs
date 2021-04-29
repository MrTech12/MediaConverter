using System;
using System.Collections.Generic;
using System.Diagnostics;

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

        //TODO: add ability for more media filetypes, other than mp4.
        public override void CreateFilename()
        {
            foreach (var item in this.selectedFiles)
            {
                audioFilename.Add(item.Replace(".mp4", ".mp3"));
            }
        }

        public void ExtractAudio()
        {
            CreateFilename();

            for (int i = 0; i < this.selectedFiles.Length; i++)
            {
                //TODO: change to a safer method to add arguments to a commandline application.
                string command = @"/C ffmpeg -i " + "\"" + this.selectedFiles[i] + "\"" + " " + "\"" + this.audioFilename[i] + "\"";
                Process process = Process.Start("CMD.exe", command);
                process.WaitForExit();
            }
        }
    }
}
