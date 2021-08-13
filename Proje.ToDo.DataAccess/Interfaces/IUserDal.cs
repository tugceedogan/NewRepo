using Proje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace Proje.ToDo.DataAccess.Interfaces
{
    public interface IUserDal
    {
        void Save(User table);
        void Delete(User table);
        void Update(User table);
        User GetIdWithOneWork(int id);
        List<User> GetAllWork();
    }
}

