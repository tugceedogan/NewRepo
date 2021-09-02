using Microsoft.EntityFrameworkCore;
using Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Contexts;
using Proje.ToDo.DataAccess.Interfaces;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Repositories
{
    public class EfWorkRepository : EfGenericRepository<Work>, IWorkDal
    {
        public List<Work> GetirAciliyetIleTamamlanmayan()
        {
            using(var context=new ToDoContext())
            {
                return context.Works.Include(I => I.Aciliyet).Where(I => !I.State).OrderByDescending(I => I.CreationDate).ToList();
            }
        }
    }

}
