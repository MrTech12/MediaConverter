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
        int audioAmountBeforeConversion;
        int audioAmountAfterConversion;

        [TestMethod]
        public void ChangeToWAVType()
        {
            // arrange
            List<string> audioFiles = new List<string>();
            selectedAudioTypes.Add(new TypeWAV());
            List<string> selectedFilePaths = new List<string>() { @"C:\tmp\1.mp4", @"C:\tmp\2.mp4" };
            audioFileHandling = new AudioFileHandling(selectedFilePaths, selectedAudioTypes);

            // act
            audioAmountBeforeConversion = audioFileHandling.AudioFiles.Count;
            audioFileHandling.ChangeFiletype();
            audioAmountAfterConversion = audioFileHandling.AudioFiles.Count;
            audioFiles = audioFileHandling.AudioFiles;

            // assert
            Assert.AreEqual(0, audioAmountBeforeConversion);
            Assert.AreEqual(2, audioAmountAfterConversion);
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
            audioAmountBeforeConversion = audioFileHandling.AudioFiles.Count;
            audioFileHandling.ChangeFiletype();
            audioAmountAfterConversion = audioFileHandling.AudioFiles.Count;
            audioFiles = audioFileHandling.AudioFiles;

            // assert
            Assert.AreEqual(0, audioAmountBeforeConversion);
            Assert.AreEqual(2, audioAmountAfterConversion);
            Assert.AreEqual("C:\tmp\test2.mp3", audioFiles[1]);
        }
    }
}
