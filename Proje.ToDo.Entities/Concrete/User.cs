using Proje.ToDo.Entities.Interfaces;
using System.Collections.Generic;

namespace Proje.ToDo.Entities.Concrete
{
  public class User:ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string  Email { get; set; }
        public int Number { get; set; }
        public List<Work> Works { get; set; }


    }
}
