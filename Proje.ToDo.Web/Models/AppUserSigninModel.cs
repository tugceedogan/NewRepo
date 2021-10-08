using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.Models
{
    public class AppUserSigninModel
    {

        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        [Display(Name = "Kullanıcı Adı:")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Parola alanı boş geçilemez")]
        [Display(Name = "Parola:")]
        public string Password { get; set; }
        [Display(Name ="Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}
