using Proje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Entities.Concrete
{
    public class Aciliyet:ITable
    {
        public int Id { get; set; }
        public string Tanim { get; set; }
        public List<Work> Works { get; set; }
    }
}
