using DAL.Abstract;
using DAL.Concrete.Repositories;
using EL.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EfContentDal : GenericRepository<Content>, IContentDal
    {
    }
}
