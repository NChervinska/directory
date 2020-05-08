using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryLibrary.Models
{
    [Serializable]
    public class Illness
    {
        public List<string> Symptoms { set; get; }
        public string Name { get; set; }
        public List<Portion> Portions { get; set; }
    }
}
