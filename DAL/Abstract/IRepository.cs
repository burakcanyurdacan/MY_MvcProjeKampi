using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
        List<T> GetAllFilter(Expression<Func<T, bool>> filter);
    }
}