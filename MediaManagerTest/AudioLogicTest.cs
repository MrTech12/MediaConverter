using BusinessLogicLayer.Audio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MediaManagerTest
{
    [TestClass]
    public class AudioLogicTest
    {
        AudioFileHandling audioFileHandling;
        private List<AudioType> selectedAudioTypes = new List<AudioType>();
        int before;
        int after;

        [TestMethod]
        public void ChangeToWAVType()
        {
            // arrange
            List<string> audioFiles = new List<string>();
            selectedAudioTypes.Add(new TypeWAV());
            List<string> selectedFilePaths = new List<string>() { @"C:\tmp\1.mp4", @"C:\tmp\2.mp4" };
            audioFileHandling = new AudioFileHandling(selectedFilePaths, selectedAudioTypes);

            // act
            before = audioFileHandling.AudioFiles.Count;
            audioFileHandling.ChangeFiletype();
            after = audioFileHandling.AudioFiles.Count;
            audioFiles = audioFileHandling.AudioFiles;

            // assert
            Assert.AreEqual(0, before);
            Assert.AreEqual(2, after);
            Assert.AreEqual(@"C:\tmp\1.wav", audioFiles[0]);
        }

        [TestMethod]
        public void ChangeToMP3Type()
        {
            // arrange
            List<string> audioFiles = new List<string>();
            selectedAudioTypes.Add(new TypeMP3());
            List<string> selectedFilePaths = new List<string>() { "C:\tmp\test1.mp4", "C:\tmp\test2.mp4" };
            audioFileHandling = new AudioFileHandling(selectedFilePaths, selectedAudioTypes);

            // act
            before = audioFileHandling.AudioFiles.Count;
            audioFileHandling.ChangeFiletype();
            after = audioFileHandling.AudioFiles.Count;
            audioFiles = audioFileHandling.AudioFiles;

            // assert
            Assert.AreEqual(0, before);
            Assert.AreEqual(2, after);
            Assert.AreEqual("C:\tmp\test2.mp3", audioFiles[1]);
        }
    }
}
