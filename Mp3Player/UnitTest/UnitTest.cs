using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestVolume()
        {
            Player.Player.checkVolume(Mp3Player.Form1.player.Volume);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestPaths()
        {
            Player.Player.checkFiles(Mp3Player.Form1.player.Files);
        }
    }
}
