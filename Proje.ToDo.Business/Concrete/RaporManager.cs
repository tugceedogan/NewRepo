using Proje.ToDo.Business.Interfaces;
using Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Repositories;
using Proje.ToDo.DataAccess.Interfaces;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Concrete
{
    public class RaporManager : IRaporService
    {
        private readonly IRaporDal _raporDal;
        public RaporManager(IRaporDal raporDal)
        {
            _raporDal = raporDal;
        }
        public void Delete(Rapor table)
        {
            _raporDal.Delete(table);
        }

        public List<Rapor> GetAll()
        {
            return _raporDal.GetAll();
        }

        public Rapor GetIdWithOne(int id)
        {
            return _raporDal.GetIdWithOne(id);
        }

        public void Save(Rapor table)
        {
            _raporDal.Save(table);
        }

        public void Update(Rapor table)
        {
            _raporDal.Update(table);
        }
    }
}
