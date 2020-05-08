using System;
using DirectoryLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoctorDirectoryTest
{
    [TestClass]
    public class DirectoryTest1
    {
        [TestMethod]
        public void FillData()
        {
            Directory directory = new Directory();
            directory.FillTestData(100);
            Assert.AreEqual(directory.Doctors[0].Name, "Doctor1");
        }
    }
}
