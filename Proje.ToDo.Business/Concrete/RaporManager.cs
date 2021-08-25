using Proje.ToDo.Business.Interfaces;
using Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Repositories;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Concrete
{
    public class RaporManager : IRaporService
    {
        private readonly EfRaporRepository raporRepository;
        public RaporManager()
        {
            raporRepository = new EfRaporRepository();
        }
        public void Delete(Rapor table)
        {
            raporRepository.Delete(table);
        }

        public List<Rapor> GetAll()
        {
            return raporRepository.GetAll();
        }

        public Rapor GetIdWithOne(int id)
        {
            return raporRepository.GetIdWithOne(id);
        }

        public void Save(Rapor table)
        {
            raporRepository.Save(table);
        }

        public void Update(Rapor table)
        {
            raporRepository.Update(table);
        }
    }
}
