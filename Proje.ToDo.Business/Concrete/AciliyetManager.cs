using Proje.ToDo.Business.Interfaces;
using Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Repositories;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Concrete
{
    public class AciliyetManager : IAciliyetService
    {
        private readonly EfAciliyetRepository efAciliyetRepository;
        public AciliyetManager()
        {
            efAciliyetRepository = new EfAciliyetRepository();  
        }
        public void Delete(Aciliyet table)
        {
           efAciliyetRepository.Delete(table);
        }

        public List<Aciliyet> GetAll()
        {
            return efAciliyetRepository.GetAll();
        }

        public Aciliyet GetIdWithOne(int id)
        {
            return efAciliyetRepository.GetIdWithOne(id);
        }

        public void Save(Aciliyet table)
        {
            efAciliyetRepository.Save(table);
        }

        public void Update(Aciliyet table)
        {
            efAciliyetRepository.Update(table);
        }
    }
}
