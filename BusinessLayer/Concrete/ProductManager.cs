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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product IGet(int id)
        {
            return _productDal.Get(id);
        }

        public List<Product> IGetList()
        {
            return _productDal.GetList();
        }

        public void TDelete(Product item)
        {
            _productDal.Delete(item);
        }

        public void TInsert(Product item)
        {
            _productDal.Insert(item);
        }

        public void TUpdate(Product item)
        {
            _productDal.Update(item);
        }
    }
}
