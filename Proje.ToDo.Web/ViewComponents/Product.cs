using Microsoft.AspNetCore.Mvc;
using Proje.ToDo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.ViewComponents
{
    public class Product : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<MusteriViewModel> yenimusteri = new List<MusteriViewModel>();

            

            return View("Yeni", yenimusteri);
        }
    }
}
