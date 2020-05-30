using System;

namespace DirectoryLibrary.Models
{
    [Serializable]
    // Класс для порции
    public class Portion
    {
        public Drug Drug { get; set; }
        public int Amount { get; set; }
    }
}
