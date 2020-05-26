using DirectoryLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoctorDirectoryTest
{
    [TestClass]
    public class DirectoryTest1
    {
        [TestMethod]
        public void FillData2()
        {
            Directory directory = new Directory();
            directory.FillTestData(100);
            Assert.AreEqual(directory.Illnesses[2].Name, "Illness2");
        }
        public void Test3()
        {
            Directory directory = new Directory();
            directory.FillTestData(100);
            Assert.AreEqual(directory.Illnesses[4].Symptoms[0], "Symptom8");
        }
        public void FillData()
        {
            Directory directory = new Directory();
            directory.FillTestData(100);
            Assert.AreEqual(directory.Doctors[0].Name, "Doctor0");
        }

    }
}
