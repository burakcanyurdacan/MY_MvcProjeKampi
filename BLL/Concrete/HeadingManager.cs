using BLL.Abstract;
using DAL.Abstract;
using EL.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;
        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal= headingDal;
        }

        public Heading GetHeadingById(int id)
        {
            return _headingDal.Get(x => x.HeadingId == id);
        }

        public List<Heading> GetHeadings()
        {
            return _headingDal.List();
        }

        public void HeadingAddBLL(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void HeadingDeleteBLL(Heading heading)
        {
            _headingDal.Delete(heading);
        }

        public void HeadingUpdateBLL(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}