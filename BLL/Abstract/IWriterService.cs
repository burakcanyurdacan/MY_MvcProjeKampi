using EL.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetWriters();
        void WriterAddBLL(Writer writer);
        void WriterDeleteBLL(Writer writer);
        void WriterUpdateBLL(Writer writer);
        Writer GetWriterById(int id);
    }
}
