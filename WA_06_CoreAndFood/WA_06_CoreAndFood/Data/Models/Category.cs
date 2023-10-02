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

        [Required(ErrorMessage = "Category Name Not Empty")]
        [StringLength(20, ErrorMessage = "Please only enter 4-20 length characters", MinimumLength = 4)]
        public string Name { get; set; }

        public string Description { get; set; }
        public bool Status { get; set; }

        public List<Food> Foods { get; set; }
    }
}
