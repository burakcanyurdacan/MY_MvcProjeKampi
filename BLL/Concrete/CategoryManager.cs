using BLL.Abstract;
using DAL.Abstract;
using DAL.Concrete.Repositories;
using EL.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class CategoryManager : ICategoryService
    {
        #region Constructor
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        #endregion

        public void CategoryAddBLL(Category category)
        {

            _categoryDal.Insert(category);
        }

        public Category GetByCategoryId(int id)
        {
            return _categoryDal.Get(x => x.CategoryId == id);
        }

        public List<Category> GetCategories()
        {
            return _categoryDal.List();
        }

        #region BLL Üzerinden Çağrılmayan Metotlar
        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetListBLL()
        //{
        //    return repo.List();
        //}

        //public void AddCategoryBLL(Category p)
        //{
        //    if (string.IsNullOrWhiteSpace(p.CategoryName))
        //    {
        //        //Hata mesajı verilecek
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}
        #endregion
    }
}
