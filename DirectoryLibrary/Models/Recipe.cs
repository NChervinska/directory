using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryLibrary.Models
{
    [Serializable]
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
