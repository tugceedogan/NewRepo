using Proje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace Proje.ToDo.DataAccess.Interfaces
{
    public interface IWorkDal : IGenericDal<Work>
    {

        List<Work> GetirAciliyetIleTamamlanmayan();
        List<Work> GetAllTable();
        Work GetirAciliyetIleId(int id);
    }
}
