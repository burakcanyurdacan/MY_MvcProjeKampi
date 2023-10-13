using EL.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        void CategoryAddBLL(Category category);
    }
}