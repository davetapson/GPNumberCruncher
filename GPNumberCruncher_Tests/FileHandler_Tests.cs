using GPNumberCruncher;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPNumberCruncher_Tests
{
    [TestClass]
    public class FileHandler_Tests
    {
        string testFileName = "TestFile.txt";

        [TestMethod]
        public void CheckFileExists_ExistingFile_Test()
        {
            // assemble
            int expected = 1;

            CreateFile(expected);

            // act
            FileHandler.CheckFileExists(testFileName);

            int actual = GetSavedNumber();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckFileExists_NoFile_Test()
        {
            // assemble
            int expected = 0; // this is what file is initialised with if no file exists
            File.Delete(testFileName);

            // act
            FileHandler.CheckFileExists(testFileName);
            int actual = GetSavedNumber();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSavedNumber_Test()
        {
            // assemble
            int expected = 2;

            CreateFile(expected);

            // act
            int actual = FileHandler.GetSavedNumber(testFileName);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SaveNumber_Test()
        {
            // assemble
            int expected = 3;

            // act
            FileHandler.SaveNumber(testFileName, expected);

            int actual = GetSavedNumber();

            // assert
            Assert.AreEqual(expected, actual);
        }

        private int GetSavedNumber()
        {
            StreamReader file = new(testFileName);
            var line = file.ReadLine();
            file.Close();

            return Convert.ToInt32(line);
        }

        private void CreateFile(int expected)
        {
            FileStream fileStream = File.OpenWrite(testFileName);

            Byte[] info = new UTF8Encoding(true).GetBytes(expected.ToString());

            fileStream.Write(info, 0, info.Length);
            fileStream.Close();
        }
    }
}
