using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WA_06_CoreAndFood.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        Context c = new Context();

        public List<Category> CategoryList()
        {
            return c.Categories.ToList();
        }

        public void CategoryAdd(Category ct)
        {
            c.Categories.Add(ct);
            c.SaveChanges();
        }

        public void CategoryDelete(Category ct)
        {
            c.Categories.Remove(ct);
            c.SaveChanges();
        }

        public void CategoryUpdate(Category ct)
        {
            c.Categories.Update(ct);
            c.SaveChanges();
        }

        public void GetCategory(int id)
        {
            c.Categories.Find(id);
        }
    }
}
