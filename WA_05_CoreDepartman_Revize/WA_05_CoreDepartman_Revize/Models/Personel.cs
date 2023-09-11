using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WA_05_CoreDepartman_Revize.Models
{
    public class Personel
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }

        public Birim Birim { get; set; }
        public int BirimID { get; set; }
    }
}
