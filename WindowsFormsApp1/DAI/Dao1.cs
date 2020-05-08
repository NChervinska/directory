using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using Directory = WindowsFormsApp1.Models.Directory;

namespace DoctorDirectory.DAI
{
    class Dao1
    {
        private readonly Directory directory;
        const string DOCTORS = "doctors.txt";
        const string DRUGS = "drugs.txt";
        const string ILLNESSES = "illnesses.txt";
        const string RECIPES = "recipes.txt";
        public Dao1(Directory directory)
        {
            this.directory = directory;
        }
        public void Save()
        {
            SaveDoctors();
            SaveDrugs();
            SaveIllnesses();
            SaveRecipes();
        }
        private void SaveDoctors()
        {
            using (var wr = new StreamWriter(DOCTORS))
            {
                wr.WriteLine(directory.Doctors.Count);
                foreach (var d in directory.Doctors)
                {
                    wr.WriteLine(d.Name);
                    wr.WriteLine(d.Password);
                }
            }
        }
        private void SaveDrugs()
        {
            using (var wr = new StreamWriter(DRUGS))
            {
                wr.WriteLine(directory.Drugs.Count);
                foreach (var d in directory.Drugs)
                {
                    wr.WriteLine(d.Name);
                    wr.WriteLine(d.Total);
                    wr.WriteLine(d.Unit);
                    wr.WriteLine(d.Change.Count);
                    foreach (var c in d.Change)
                    {
                        wr.WriteLine(c);
                    }
                }
            }
        }
        private void SaveIllnesses()
        {
            using (var wr = new StreamWriter(ILLNESSES))
            {
                wr.WriteLine(directory.Illnesses.Count);
                foreach (var i in directory.Illnesses)
                {
                    wr.WriteLine(i.Name);
                    wr.WriteLine(i.Portions.Count);
                    foreach (var p in i.Portions)
                    {
                        wr.WriteLine(p.Drug.Name);
                        wr.WriteLine(p.Amount);
                    }
                    wr.WriteLine(i.Symptoms.Count);
                    foreach (var s in i.Symptoms)
                    {
                        wr.WriteLine(s);
                    }
                }
            }
        }
        private void SaveRecipes()
        {
            using (var wr = new StreamWriter(RECIPES))
            {
                wr.WriteLine(directory.Recipes.Count);
                foreach (var r in directory.Recipes)
                {
                    wr.WriteLine(r.Doctor.Name);               
                    wr.WriteLine(r.Illness.Name);
                    wr.WriteLine(r.DateTime);
                }
            }

        }
        //...................................................................
        public void Load()
        {
            LoadDoctors();
            LoadDrugs();
            LoadIllnesses();
            LoadRecipes();
        }
        private void LoadDoctors()
        {
            using (var rd = new StreamReader(DOCTORS))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                directory.Doctors.Clear();
                for (int i = 0; i < n; i++)
                {
                    directory.Doctors.Add(new Doctor
                    {
                        Name = rd.ReadLine(),
                        Password = rd.ReadLine(),
                    });
                }
            }
        } 
        private void LoadIllnesses()
        {
            using (var rd = new StreamReader(ILLNESSES))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                directory.Illnesses.Clear(); 
                for (int i = 0; i < n; i++)
                {
                    directory.Illnesses.Add(new Illness
                    {
                        Name = rd.ReadLine(),
                        Portions = ReadPortions(rd),
                        Symptoms = ReadString(rd)
                    });
                }
            }
        }
        private void LoadDrugs()
        {
            using (var rd = new StreamReader(DRUGS))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                directory.Drugs.Clear(); 
                for (int i = 0; i < n; i++)
                {
                    directory.Drugs.Add(new Drug
                    {
                        Name = rd.ReadLine(),
                        Total = Convert.ToInt32(rd.ReadLine()),
                        Unit = rd.ReadLine(),
                        Change = ReadString(rd)
                    }) ;
                    
                }
            }
        } 
        private void LoadRecipes()
        {
            using (var rd = new StreamReader(RECIPES))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                directory.Recipes.Clear(); 
                for (int i = 0; i < n; i++)
                {
                    var doc = rd.ReadLine();
                    var ill = rd.ReadLine(); 
                    var time = Convert.ToDateTime(rd.ReadLine());
                    directory.Recipes.Add(new Recipe(GetDoctorByName(doc), GetIllnessByName(ill),time));
                }
            }
        }
        private Doctor GetDoctorByName(string name) =>
             directory.Doctors.Single(b => b.Name == name);
        private Illness GetIllnessByName(string name) =>
             directory.Illnesses.Single(b => b.Name == name);
        private Drug GetDrugByName(string name) =>
            directory.Drugs.Single(p => p.Name == name);
        private List<string> ReadString(StreamReader rd)
        {
            int n = Convert.ToInt32(rd.ReadLine());
            var ch = new List<string>(); 
            for (int i = 0; i < n; i++)
            {
                ch.Add(rd.ReadLine());
            }
            return ch;
        }
        private List<Portion> ReadPortions(StreamReader rd)
        {
            int n = Convert.ToInt32(rd.ReadLine());
            var ps = new List<Portion>();
            for (int i = 0; i < n; i++)
            {
                var drug = rd.ReadLine();
                var amount = Convert.ToInt32(rd.ReadLine());
                ps.Add(new Portion
                {
                    Amount = amount,
                    Drug = GetDrugByName(drug)
                });
            }
            return ps;
        }
    }
}
