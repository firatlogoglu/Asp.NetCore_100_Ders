using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA_06_CoreAndFood.Data.Models;

namespace WA_06_CoreAndFood.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        Context c = new Context();

        public List<T> CategoryList()
        {
            return c.Set<T>().ToList();
        }

        public void CategoryAdd(T p)
        {
            c.Set<T>().Add(p);
            c.SaveChanges();
        }

        public void CategoryDelete(T p)
        {
            c.Set<T>().Remove(p);
            c.SaveChanges();
        }

        public void CategoryUpdate(T p)
        {
            c.Set<T>().Update(p);
            c.SaveChanges();
        }

        public void GetCategory(int id)
        {
            c.Set<T>().Find(id);
        }
    }
}
