using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryLibrary.Models
{
    [Serializable]
    public abstract class User
    {
        public string Name { get; set; } 
        public string Password { get; set; }
    }
}
