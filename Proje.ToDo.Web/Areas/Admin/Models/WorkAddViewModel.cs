using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Proje.ToDo.Web.Areas.Admin.Models
{
    public class WorkAddViewModel
    {
        [Required(ErrorMessage="ad alanı gereklidir")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0,int.MaxValue,ErrorMessage="Lütfen profil durumu seçiniz")]
        public int ProfilId { get; set; }
       
    }
}
