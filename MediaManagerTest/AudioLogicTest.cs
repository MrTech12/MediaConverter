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
        public void ChangeToWAVType()
        {
            // arrange
            List<string> audioFiles = new List<string>();
            string[] files = new string[] { "1.mp4", "2.mp4" };
            audioLogic = new AudioLogic(files);

            // act
            before = audioLogic.AudioFiles.Count;
            audioLogic.ChangeFiletype("wav");
            after = audioLogic.AudioFiles.Count;
            audioFiles = audioLogic.AudioFiles;

            // assert
            Assert.AreEqual(0, before);
            Assert.AreEqual(2, after);
            Assert.AreEqual("1.wav", audioFiles[0]);
        }

        [TestMethod]
        public void ChangeToMP3Type()
        {
            // arrange
            List<string> audioFiles = new List<string>();
            string[] files = new string[] { "test1.mp4", "test2.mp4" };
            audioLogic = new AudioLogic(files);

            // act
            before = audioLogic.AudioFiles.Count;
            audioLogic.ChangeFiletype("mp3");
            after = audioLogic.AudioFiles.Count;
            audioFiles = audioLogic.AudioFiles;

            // assert
            Assert.AreEqual(0, before);
            Assert.AreEqual(2, after);
            Assert.AreEqual("test2.mp3", audioFiles[1]);
        }
    }
}
