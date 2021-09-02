using Proje.ToDo.Business.Interfaces;
using Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Repositories;
using Proje.ToDo.DataAccess.Interfaces;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Concrete
{
    public class AciliyetManager : IAciliyetService
    {
        private readonly IAciliyetDal _aciliyetDal;
        public AciliyetManager(IAciliyetDal aciliyetDal)
        {
            _aciliyetDal = aciliyetDal;
        }
        public void Delete(Aciliyet table)
        {
            _aciliyetDal.Delete(table);
        }

        public List<Aciliyet> GetAll()
        {
            return _aciliyetDal.GetAll();
        }

        public Aciliyet GetIdWithOne(int id)
        {
            return _aciliyetDal.GetIdWithOne(id);
        }

        public void Save(Aciliyet table)
        {
            _aciliyetDal.Save(table);
        }

        public void Update(Aciliyet table)
        {
            _aciliyetDal.Update(table);
        }
    }
}
