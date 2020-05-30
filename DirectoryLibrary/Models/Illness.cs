using System;
using System.Collections.Generic;

namespace DirectoryLibrary.Models
{
    [Serializable]
    // Класс для болезни 
    public class Illness
    {
        public List<string> Symptoms { set; get; }
        public string Name { get; set; }
        public List<Portion> Portions { get; set; }
    }
}
