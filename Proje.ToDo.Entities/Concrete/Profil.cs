using Proje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Entities.Concrete
{
    public class Profil:ITable
    {
        public int Id { get; set; }
        public string About { get; set; }
        public string Experience { get; set; }
        public List<Work> Works { get; set; }
        public string Contact { get; set; }
        public string Tanim { get; set; }
    }
}
