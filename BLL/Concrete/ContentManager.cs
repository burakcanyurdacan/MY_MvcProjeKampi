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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;
        public ContentManager(IContentDal contentDal)
        {
            this._contentDal = contentDal;
        }

        public void ContentAddBLL(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentDeleteBLL(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdateBLL(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByContentId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetContents()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetContentsById(int id)
        {
            return _contentDal.List(x => x.HeadingId == id);
        }
    }
}