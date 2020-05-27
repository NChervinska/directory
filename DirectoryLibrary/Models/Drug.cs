using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryLibrary.Models
{
    [Serializable]
    // Класс для рекарств
    public class Drug
    {
        public string Name { get; set; }
        public List<string> Change { set; get; }
        public int Total { set; get; } 
        public string Unit { set; get; }
    }
}
