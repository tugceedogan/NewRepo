using System;
using Proje.ToDo.Entities.Concrete;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Interfaces
{
    public interface IWorkService : IGenericService<Work>
    {
        List<Work> GetirProfilIleTamamlanmayan();
        List<Work> GetAllTable();
        Work GetirProfilIleId(int id);
        List<Work> GetirileAppUserId(int appUserId);
    }
}
