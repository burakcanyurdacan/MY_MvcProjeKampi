using DAL.Abstract;
using EL.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.Repositories
{
    public class WriterRepository : IWriterDal
    {
        Context c = new Context();
        DbSet<Writer> _object;
        public void Delete(Writer item)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetAllFilter(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer item)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer item)
        {
            throw new NotImplementedException();
        }
    }
}
