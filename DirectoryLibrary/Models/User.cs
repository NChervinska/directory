using System;

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
