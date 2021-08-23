using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.ToDo.Web.CustomExtentions;
using Proje.ToDo.Web.CustomFilters;
using Proje.ToDo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Tugce";
            TempData["Name"] = "Tugce";
            ViewData["Name"] = "Tugce";


            SetSession();
            ViewBag.Cookie = GetSession();


            return View(new List<MusteriViewModel>() {
                new MusteriViewModel(){Ad="tugce1"},
                new MusteriViewModel(){Ad="tugce2"},
                new MusteriViewModel(){Ad="tugce3"},
            });
        }

        public IActionResult Sonuc()
        {
            return View();
        }

        public IActionResult KayitOl()
        {
            return View();
        }

        [AdTugceOlamaz]
        [HttpPost]
        public IActionResult KayitOl2(KullaniciKayitViewModel model)
        {
            //string ad = HttpContext.Request.Form["Ad"].ToString();
            if (ModelState.IsValid)
            {

            }
            ModelState.AddModelError(nameof(KullaniciKayitViewModel.Ad), "ad gerekli");

            ModelState.AddModelError("", "modelle ilgili hata");
            return View("KayitOl", model);
        }

        public void SetCookie()
        {
            HttpContext.Response.Cookies.Append("kisi", "yavuz", new Microsoft.AspNetCore.Http.CookieOptions()
            {
                Expires = DateTime.Now.AddDays(20),
                HttpOnly = true,
                SameSite=Microsoft.AspNetCore.Http.SameSiteMode.Strict,
                Secure=true
            });
        }
        public string GetCookie()
        {
            return HttpContext.Request.Cookies["kisi"];
        }
        public void SetSession()
        {
            HttpContext.Session.SetObject("kisi",new KullaniciKayitViewModel() { Ad="tugce",Soyad="dogan"});
        }
        public KullaniciKayitViewModel GetSession()
        {
            return HttpContext.Session.GetObject<KullaniciKayitViewModel>("kisi");
        }
        public IActionResult PageError(int code)
        {
            ViewBag.Code = code;
            if (code == 404)
            {
                ViewBag.Message = "sayfa bulunamadı.";
            }
            return View();
            
        }
        public IActionResult Error()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            return View();
        }
        public IActionResult Hata()
        {
            throw new Exception("hata oluştu");
        }
    }
}
