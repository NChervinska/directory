using WindowsFormsApp1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Directory = WindowsFormsApp1.Models.Directory;

namespace ProductStore.Data
{
    public class Dao
    {
        private readonly Directory directory;
        const string filePath = "directory.bin";
        public Dao(Directory directory)
        {
            this.directory = directory;
        }
        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, directory);
            }
        }
        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                Directory st = (Directory)serializer.Deserialize(stream);

                Copy(st.Doctors, directory.Doctors);
                Copy(st.Drugs, directory.Drugs);
                Copy(st.Illnesses, directory.Illnesses);
                Copy(st.Recipes, directory.Recipes);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}