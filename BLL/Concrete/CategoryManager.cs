using DAL.Concrete.Repositories;
using EL.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetListBLL()
        {
            return repo.GetAll();
        }

        public void AddCategoryBLL(Category p)
        {
            if (p.CategoryName == "")
            {
                //Hata mesajı verilecek
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
