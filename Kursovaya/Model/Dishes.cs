﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Kursovaya.Model
{
    public class Dishes
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public int Price { get; set; }

        public int Ves { get; set; }

        public string Type { get; set; }

    }
}
