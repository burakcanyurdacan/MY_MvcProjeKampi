using EL.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IContentService
    {
        List<Content> GetContents();
        List<Content> GetContentsById(int id);
        void ContentAddBLL(Content content);
        Content GetByContentId(int id);
        void ContentDeleteBLL(Content content);
        void ContentUpdateBLL(Content content);
    }
}
