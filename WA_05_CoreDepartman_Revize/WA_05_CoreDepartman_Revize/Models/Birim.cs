using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WA_05_CoreDepartman_Revize.Models
{
    public class Birim
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }

        public IList<Personel> Personels { get; set; }
    }
}
