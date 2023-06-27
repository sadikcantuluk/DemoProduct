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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetCustomersListWithJob()
        {
            return _customerDal.GetCustomerListWithJob();
        }

        public Customer IGet(int id)
        {
            return _customerDal.Get(id);
        }

        public List<Customer> IGetList()
        {
            return _customerDal.GetList();
        }

        public void TDelete(Customer item)
        {
            _customerDal.Delete(item);
        }

        public void TInsert(Customer item)
        {
            _customerDal.Insert(item);
        }

        public void TUpdate(Customer item)
        {
            _customerDal.Update(item);
        }
    }
}
