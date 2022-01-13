using Proje.ToDo.Business.Interfaces;
using Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Repositories;
using Proje.ToDo.DataAccess.Interfaces;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Concrete
{
    public class WorkManager : IWorkService
    {
        private readonly IWorkDal _workDal;
        public WorkManager(IWorkDal workDal)
        {
            _workDal = workDal;
         
        }

        public void Delete(Work table)
        {
            _workDal.Delete(table);
        }

        public List<Work> GetAll()
        {
            return _workDal.GetAll();
        }

        public List<Work> GetAllTable()
        {
            return _workDal.GetAllTable();
        }

        public Work GetIdWithOne(int id)
        {
            return _workDal.GetIdWithOne(id);
        }


        public List<Work> GetirileAppUserId(int appUserId)
        {
            return _workDal.GetirileAppUserId(appUserId);
        }

        public Work GetirProfilIleId(int id)
        {
            return _workDal.GetirProfilIleId(id);
        }

        public List<Work> GetirProfilIleTamamlanmayan()
        {
            return _workDal.GetirProfilIleTamamlanmayan();
        }

        public void Save(Work table)
        {
            _workDal.Save(table);
        }

        public void Update(Work table)
        {
            _workDal.Update(table);
        }
    }

}