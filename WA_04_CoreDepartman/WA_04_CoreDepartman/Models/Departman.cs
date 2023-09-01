using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WA_04_CoreDepartman.Models
{
    public class Departman
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
    }
}
