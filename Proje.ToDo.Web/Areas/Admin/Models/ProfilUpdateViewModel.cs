using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.Areas.Admin.Models
{
    public class ProfilUpdateViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Tanim:")]
        [Required(ErrorMessage="tanım alanı gereklidir")]
        public string Tanim { get; set; }
    }
}
