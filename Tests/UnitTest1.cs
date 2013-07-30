using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstHomework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var saveInfo = new StreamWriter("test.txt");
            using (saveInfo)
            {
                SaveStream saveStream = new SaveStream();
                saveStream.HeadWriter(saveInfo);
                saveStream.WriteAuthor(saveInfo, "testAuthor");
                saveStream.WriteTitle(saveInfo, "testTitle");
                saveStream.WriteCountPages(saveInfo, "123");
                saveStream.WriteWetherRead(saveInfo, "had read");
                saveStream.EndWriter(saveInfo);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            DownloadStream downloadStream = new DownloadStream();
            bool flag = downloadStream.CompareLines("  Тестовая строка.", "Тестовая строка.   ");
            Assert.AreEqual(true, flag);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DownloadStream downloadStream = new DownloadStream();
            var readInfo = new StreamReader("text.txt");
            string testStr = downloadStream.ReadLineFromFile(readInfo);
            readInfo.Close();
            Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-8\"?>", testStr);
        }
    }
}
