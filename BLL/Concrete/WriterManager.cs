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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        public Writer GetWriterById(int id)
        {
            return _writerDal.Get(x => x.WriterId == id);
        }

        public List<Writer> GetWriters()
        {
            return _writerDal.List();
        }

        public void WriterAddBLL(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void WriterDeleteBLL(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void WriterUpdateBLL(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
