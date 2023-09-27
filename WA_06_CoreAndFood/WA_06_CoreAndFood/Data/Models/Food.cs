using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WA_06_CoreAndFood.Data.Models
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public string ThumbNailImageURL { get; set; }
        public int Stock { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
