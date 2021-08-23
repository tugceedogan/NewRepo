using Proje.ToDo.Business.Interfaces;
using Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Repositories;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Concrete
{
    public class WorkManager : IWorkService
    {
        private readonly EfWorkRepository efWorkRepository;
        public WorkManager()
        {
            efWorkRepository = new EfWorkRepository();
        }

        public void Delete(Work table)
        {
            efWorkRepository.Delete(table);
        }

        public List<Work> GetAll()
        {
            return efWorkRepository.GetAll();
        }

        public Work GetIdWithOne(int id)
        {
            return efWorkRepository.GetIdWithOne(id);
        }

        public void Save(Work table)
        {
            efWorkRepository.Save(table);
        }

        public void Update(Work table)
        {
            efWorkRepository.Update(table);
        }
    }

}