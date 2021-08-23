using Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Contexts;
using Proje.ToDo.DataAccess.Interfaces;
using Proje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Repositories
{
    public class EfGenericRepository<Table> : IGenericDal <Table>  where Table : class, ITable, new()
    {
        public void Delete(Table table)
        {
            using var context = new ToDoContext();
            context.Set<Table>().Remove(table);
            context.SaveChanges();
        }

        public List<Table> GetAll()
        {
           
            using var context = new ToDoContext();
            return context.Set<Table>().ToList();           
        }

        public Table GetIdWithOne(int id)
        {
            using var context = new ToDoContext();
            return context.Set<Table>().Find(id);
        }

        public void Save(Table table)
        {
            using var context = new ToDoContext();
            context.Set<Table>().Update(table);
            context.SaveChanges();
        }

        public void Update(Table table)
        {
            using var context = new ToDoContext();
            context.Set<Table>().Add(table);
            context.SaveChanges();
        }
    }
}
