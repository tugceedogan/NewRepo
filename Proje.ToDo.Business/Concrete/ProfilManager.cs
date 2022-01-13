using Proje.ToDo.Business.Interfaces;
using Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Repositories;
using Proje.ToDo.DataAccess.Interfaces;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Concrete
{
    public class ProfilManager : IProfilService
    {
        private readonly IProfilDal _profilDal;
        public ProfilManager(IProfilDal profilDal)
        {
            _profilDal = profilDal;
        }
        public void Delete(Profil table)
        {
            _profilDal.Delete(table);
        }

        public List<Profil> GetAll()
        {
            return _profilDal.GetAll();
        }

        public Profil GetIdWithOne(int id)
        {
            return _profilDal.GetIdWithOne(id);
        }

        public void Save(Profil table)
        {
            _profilDal.Save(table);
        }

        public void Update(Profil table)
        {
            _profilDal.Update(table);
        }
    }
}
