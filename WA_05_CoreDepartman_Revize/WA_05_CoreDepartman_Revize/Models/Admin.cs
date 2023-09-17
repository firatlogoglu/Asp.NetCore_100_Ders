using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WA_05_CoreDepartman_Revize.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string KullaniciAdi { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string Sifre { get; set; }
    }
}
