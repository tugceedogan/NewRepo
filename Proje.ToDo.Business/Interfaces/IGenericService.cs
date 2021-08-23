using Proje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Interfaces
{
    public interface IGenericService<Table> where Table: class,ITable,new()
    {
        void Save(Table table);
        void Delete(Table table);
        void Update(Table table);
        Table GetIdWithOne(int id);
        List<Table> GetAll();
    }
}
