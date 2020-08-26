using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BusinessLogicLayer
{
    public class AudioLogic : FileHandling
    {
        private string[] selectedFiles;
        private List<string> audioFilename = new List<string>();

        public AudioLogic(string[] selectedFiles)
        {
            this.selectedFiles = selectedFiles;
        }

        public override void PrepareAudioFilename()
        {
            foreach (var item in selectedFiles)
            {
                audioFilename.Add(item.Replace(".mp4", ".mp3"));
            }
        }

        public void ExtractAudio()
        {
            PrepareAudioFilename();

            for (int i = 0; i < selectedFiles.Length; i++)
            {
                string command = @"/C ffmpeg -i " + "\"" + selectedFiles[i] + "\"" + " " + "\"" + audioFilename[i] + "\"";
                Process process = Process.Start("CMD.exe", command);
                process.WaitForExit();
            }
        }
    }
}
