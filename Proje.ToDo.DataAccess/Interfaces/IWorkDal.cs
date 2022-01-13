using Proje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace Proje.ToDo.DataAccess.Interfaces
{
    public interface IWorkDal : IGenericDal<Work>
    {

        List<Work> GetirProfilIleTamamlanmayan();
        List<Work> GetAllTable();
        Work GetirProfilIleId(int id);
        List<Work> GetirileAppUserId(int appUserId);
    }
}
