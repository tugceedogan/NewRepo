using Proje.ToDo.DataAccess.Interfaces;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Repositories
{
    public class EfRaporRepository:EfGenericRepository<Rapor>,IRaporDal
    {
    }
}
