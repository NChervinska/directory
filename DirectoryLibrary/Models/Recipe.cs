using System;

namespace DirectoryLibrary.Models
{
    [Serializable]
    // Класс для рецепта
    public class Recipe
    {
        public Recipe(Doctor doctor, Illness illness, DateTime? t = null)
        {
            Illness = illness;
            Doctor = doctor;
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }
        public Doctor Doctor { private set; get; }
        public Illness Illness { private set; get; }
        public DateTime DateTime { private set; get; }
    }
}
