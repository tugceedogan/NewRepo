using Proje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace Proje.ToDo.DataAccess.Interfaces
{
    public interface IWorkDal
    {
        void Save(Work table);
        void Delete(Work table);
        void Update(Work table);
        Work GetIdWithOneWork(int id);
        List<Work> GetAllWork();
    }
}
