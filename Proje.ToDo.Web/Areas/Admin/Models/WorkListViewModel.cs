using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.Areas.Admin.Models
{
    public class WorkListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public DateTime CreationDate { get; set; }
        public int AciliyetId { get; set; }
        public Aciliyet Aciliyet { get; set; }
    }
}
