using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WA_06_CoreAndFood.Data.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Category Name Not Empty")]
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Food> Foods { get; set; }
    }
}
