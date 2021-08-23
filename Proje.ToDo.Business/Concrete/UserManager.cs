using Proje.ToDo.Business.Interfaces;
using Proje.ToDo.Business.Interfaces.NewFolder;
using Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Repositories;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly EfUserRepository efUserRepository;
        public UserManager()
        {
            efUserRepository = new EfUserRepository();
        }

        public void Delete(User table)
        {
            efUserRepository.Delete(table);
        }

        public List<User> GetAll()
        {
            return efUserRepository.GetAll();
        }

        public User GetIdWithOne(int id)
        {
            return efUserRepository.GetIdWithOne(id);
        }

        public void Save(User table)
        {
            efUserRepository.Save(table);
        }

        public void Update(User table)
        {
            efUserRepository.Update(table);
        }
    }
}
