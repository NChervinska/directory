﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
