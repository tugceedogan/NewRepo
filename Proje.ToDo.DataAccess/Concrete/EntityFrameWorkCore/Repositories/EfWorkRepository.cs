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
        public List<Work> GetAllTable()
        {
            using var context = new ToDoContext();
            return context.Works.Include(I => I.Profil).Include(I => I.Raporlar).Include(I => I.AppUser).Where(I => !I.State).OrderByDescending(I => I.CreationDate).ToList();
        }

        public Work GetirProfilIleId(int id)
        {
            using var context = new ToDoContext();
            return context.Works.Include(I => I.Profil).FirstOrDefault(I => !I.State && I.Id == id);
        }

        public List<Work> GetirProfilIleTamamlanmayan()
        {
            using var context = new ToDoContext();
            return context.Works.Include(I => I.Profil).Where(I => !I.State).OrderByDescending(I => I.CreationDate).ToList();
        }

        public List<Work> GetirileAppUserId(int appUserId)
        {
            using var context = new ToDoContext();
            return context.Works.Where(I => I.AppUserId == appUserId).ToList();
        }
    }
}
