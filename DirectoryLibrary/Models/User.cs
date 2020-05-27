using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryLibrary.Models
{
    [Serializable]
    // Общая часть для пользователей 
    public abstract class User
    {
        public string Name { get; set; } 
        public string Password { get; set; }
    }
}
