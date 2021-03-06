﻿using DirectoryLibrary.DATA;
using System;
using System.Collections.Generic;

namespace DirectoryLibrary.Models
{
    [Serializable] 
    // Класс спавочик врача
    public class Directory
    {
        public List<Doctor> Doctors { private set; get; }
        public List<Drug> Drugs { private set; get; }
        public List<Illness> Illnesses { private set; get; }
        public List<Recipe> Recipes { private set; get; }

        public bool IsDirty;
        public Directory()
        {
            Doctors = new List<Doctor>();
            Drugs = new List<Drug>();
            Illnesses = new List<Illness>();
            Recipes = new List<Recipe>();
        }
        public void FillTestData(int n)
        {
            // Doctor
            Doctors = new List<Doctor>();
            for (int i = 0; i < n/2; i++)
            {
                Doctors.Add(new Doctor { Name = $"Doctor{i}", Password = "123" });
            }
            // Drug
            Drugs = new List<Drug>();
            const int m = 4;
            for (int i = 0; i <= n - m; i++)
            {
                var ch = new List<string>();
                for (int j = 0; j < i % m; j++)
                {
                    if ((i * j) % (n - m) != i)
                        ch.Add($"Drug{(i * j) % (n - m)}");
                }
                Drugs.Add(new Drug()
                {
                    Name = $"Drug{i}",
                    Total = i * 10,
                    Unit = "mg",
                    Change = ch
                });
            }
            // Illness
            Illnesses = new List<Illness>();
            for (int i = 0; i <= n - m; i++)
            {
                var sym = new List<string>();
                var ps = new List<Portion>();
                for (int j = 0; j < i % m + 1; j++)
                {
                    ps.Add(new Portion { Drug = Drugs[(m + n + i + j) % (n - m)], Amount = (j + m)%35 + 1});
                    sym.Add($"Symptom{(j + i + m) % 16}");
                }
                Illnesses.Add(new Illness { Name = $"Illness{i}", Portions = ps, Symptoms = sym });
            }
            // Recipes
            Recipes = new List<Recipe>();
            for (int i = 0; i <= n - m; i++)
            {
                Recipes.Add(new Recipe(Doctors[i%50], Illnesses[i], DateTime.Now + TimeSpan.FromDays(i)));
            }
        }
        public void Save()
        {
            new Dao(this).Save();
        }
        public void Load()
        {
            new Dao(this).Load();
        }
    }
}
