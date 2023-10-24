using EL.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetHeadings();
        void HeadingAddBLL(Heading heading);
        void HeadingDeleteBLL(Heading heading);
        void HeadingUpdateBLL(Heading heading);
        Heading GetHeadingById(int id);
    }
}