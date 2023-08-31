using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WA_04_CoreDepartman.Models
{
    public class Context : DbContext
    {
        public DbSet<Departman> Departmen { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}
