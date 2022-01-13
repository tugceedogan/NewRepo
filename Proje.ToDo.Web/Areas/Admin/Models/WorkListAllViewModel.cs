using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.Areas.Admin.Models
{
    public class WorkListAllViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public Profil Profil { get; set; }
        public AppUser AppUser { get; set; }
        public List<Rapor> Raporlar { get; set; }

    }
}
