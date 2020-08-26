using BusinessLogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MediaManagerTest
{
    [TestClass]
    public class AudioLogicTest
    {
        AudioLogic audioLogic;
        int before;
        int after;

        [TestMethod]
        public void GettingTwoAudioFiles()
        {
            // arrange
            List<string> audioFiles = new List<string>();
            string[] files = new string[] { "1.mp4", "2.mp4" };
            audioLogic = new AudioLogic(files);

            // act
            before = audioLogic.AudioFilename.Count;
            audioLogic.PrepareAudioFilename();
            after = audioLogic.AudioFilename.Count;
            audioFiles = audioLogic.AudioFilename;

            // assert
            Assert.AreEqual(0, before);
            Assert.AreEqual(2, after);
            Assert.AreEqual("1.mp3", audioFiles[0]);
        }
    }
}
