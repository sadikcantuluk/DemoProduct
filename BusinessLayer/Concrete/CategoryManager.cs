using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category IGet(int id)
        {
            return _categoryDal.Get(id);
        }

        public List<Category> IGetList()
        {
            return _categoryDal.GetList();
        }

        public void TDelete(Category item)
        {
            _categoryDal.Delete(item);
        }

        public void TInsert(Category item)
        {
            _categoryDal.Insert(item);
        }

        public void TUpdate(Category item)
        {
            _categoryDal.Update(item);
        }
    }
}
