using Proje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Entities.Concrete
{
    public class Rapor:ITable
    {
        public int Id { get; set; }
        public string Tanim { get; set; }
        public string Detay { get; set; }
        public int WorkID { get; set; }
        public Work Work { get; set; }
    }
}
