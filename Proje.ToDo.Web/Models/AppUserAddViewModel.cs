using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.Models
{
    public class AppUserAddViewModel
    {
        [Required(ErrorMessage="Kullanıcı adı boş geçilemez")]
        [Display(Name="Kullanıcı Adı:")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]

        [Required(ErrorMessage = "Parola alanı boş geçilemez")]
        [Display(Name = "Parola:")]
        public string Password { get; set; }

        [DataType(DataType.Password)]

        [Display(Name = "Parolanızı tekrar giriniz:")]

        [Compare("Password", ErrorMessage = "Parolalar eşleşmiyor")]
        public string ConfirmPassword { get; set; }

        [Display(Name ="Email:")]
        [Required(ErrorMessage = "Email alanı boş geçilemez")]
        public string Email { get; set; }

        [Display(Name="Adınız:")]
        [Required(ErrorMessage = "Name alanı boş geçilemez")]
        public string Name { get; set; }

        [Display(Name="Soyadınız:")]
        [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        public string SurName { get; set; }

    }
}
