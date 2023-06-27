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
    public class JobManager : IJobService
    {
        IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public Job IGet(int id)
        {
            return _jobDal.Get(id);
        }

        public List<Job> IGetList()
        {
            return _jobDal.GetList();
        }

        public void TDelete(Job item)
        {
            _jobDal.Delete(item);
        }

        public void TInsert(Job item)
        {
            _jobDal.Insert(item);
        }

        public void TUpdate(Job item)
        {
            _jobDal.Update(item);
        }
    }
}
