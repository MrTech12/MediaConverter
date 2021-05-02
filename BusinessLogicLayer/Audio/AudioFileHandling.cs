using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BusinessLogicLayer.Audio
{
    public class AudioFileHandling : FileHandling
    {
        private List<AudioType> selectedAudioTypes = new List<AudioType>();
        private List<string> selectedFilePaths = new List<string>();
        private List<string> audioFiles = new List<string>();

        public List<string> SelectedFiles { get { return this.selectedFilePaths; } set { this.selectedFilePaths = value; } }
        public List<string> AudioFiles { get { return this.audioFiles; } set { this.audioFiles = value; } }
        public List<AudioType> AudioTypes { get { return this.selectedAudioTypes; } set { this.selectedAudioTypes = value; } }

        public AudioFileHandling(List<string> selectedFilePaths, List<AudioType> selectedAudioTypes)
        {
            this.selectedFilePaths = selectedFilePaths;
            this.selectedAudioTypes = selectedAudioTypes;
        }

        public override void ChangeFiletype()
        {
            foreach (var filePath in this.selectedFilePaths)
            {
                int dotIndex = filePath.IndexOf(".");
                string filePathWithoutType = filePath.Substring(0, dotIndex);

                foreach (var audioType in this.selectedAudioTypes)
                {
                    audioFiles.Add(audioType.AddAudioFiletype(filePathWithoutType));
                }
            }
        }

        public override void CreateNewFile()
        {
            Process process = new Process();
            process.StartInfo.FileName = "ffmpeg.exe";

            for (int i = 0; i < this.selectedFilePaths.Count; i++)
            {
                process.StartInfo.Arguments = String.Format(@"-i ""{0}"" ""{1}""", this.selectedFilePaths[i], this.audioFiles[i]);
                process.Start();
                process.WaitForExit();
            }
        }
    }
}
