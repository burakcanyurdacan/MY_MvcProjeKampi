using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> obj;
        public GenericRepository()
        {
            obj = c.Set<T>();
        }

        public void Delete(T item)
        {
            obj.Remove(item);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return obj.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return obj.Where(filter).ToList();
        }

        public void Insert(T item)
        {
            obj.Add(item);
            c.SaveChanges();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}