﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WA_06_CoreAndFood.Data.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AdminRole { get; set; }
    }
}
