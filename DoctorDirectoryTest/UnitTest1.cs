using DirectoryLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoctorDirectoryTest
{
    [TestClass] 
    // Проверка правильности тестовых данных 
    public class DirectoryTest1
    {
        [TestMethod]
        
        public void FillData1()
        {
            Directory directory = new Directory();
            directory.FillTestData(100);
            Assert.AreEqual(directory.Drugs[0].Name, "Drug0");
        }
        public void FillData2()
        {
            Directory directory = new Directory();
            directory.FillTestData(100);
            Assert.AreEqual(directory.Recipes[0].Illness.Name, "Illness0");
        }
        public void FillData3()
        {
            Directory directory = new Directory();
            directory.FillTestData(100);
            Assert.AreEqual(directory.Illnesses[2].Name, "Illness2");
        }
        public void FillData4()
        {
            Directory directory = new Directory();
            directory.FillTestData(100);
            Assert.AreEqual(directory.Illnesses[4].Symptoms[0], "Symptom8");
        }
        public void FillData5()
        {
            Directory directory = new Directory();
            directory.FillTestData(100);
            Assert.AreEqual(directory.Doctors[0].Name, "Doctor0");
        }
    }
}
