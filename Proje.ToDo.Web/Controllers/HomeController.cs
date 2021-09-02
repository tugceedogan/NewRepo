using Microsoft.AspNetCore.Mvc;
using Proje.ToDo.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Proje.ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        Business.Interfaces.IWorkService _workService;
        public HomeController(Business.Interfaces.IWorkService workService)
        {
            _workService = workService;
        }
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
