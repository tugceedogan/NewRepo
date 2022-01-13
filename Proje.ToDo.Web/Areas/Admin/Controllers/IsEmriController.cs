using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proje.ToDo.Business.Interfaces;
using Proje.ToDo.Entities.Concrete;
using Proje.ToDo.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class IsEmriController : Controller
    {

        private readonly IAppUserService _appUserService;
        private readonly IWorkService _workService;
        public IsEmriController(IAppUserService appUserService, IWorkService workService)
        {
            _workService = workService;
            _appUserService = appUserService;
        }
        public IActionResult Index()
        {        
            //var model=_appUserService.GetNotAdmin();            
            List<Work> works=_workService.GetAllTable();
            List<WorkListAllViewModel> models = new List<WorkListAllViewModel>();
            foreach(var item in works)
            {
                WorkListAllViewModel model = new WorkListAllViewModel
                {
                    Id = item.Id,
                    Description = item.Description,
                    Profil = item.Profil,
                    Name = item.Name,
                    AppUser = item.AppUser,
                    CreationDate = item.CreationDate,
                    Raporlar = item.Raporlar
                };
                models.Add(model);
            }
            return View(models);
        }

        public IActionResult AtaPersonel(int id,string s,int sayfa=1)
        {
            TempData["Active"] = "isemri";
            ViewBag.AktifSayfa = sayfa;

            ViewBag.Aranan = s;

            var work = _workService.GetirProfilIleId(id);

            //ViewBag.ToplamSayfa =(int)Math.Ceiling((double) _appUserService.GetNotAdmin().Count/3);

            var personeller = _appUserService.GetNotAdmin(out int toplamSayfa,s,sayfa);
            ViewBag.ToplamSayfa = toplamSayfa;

            List<AppUserListViewModel> appUserListModel = new List<AppUserListViewModel>();
            foreach(var item in personeller)
            {
                AppUserListViewModel model = new AppUserListViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    SurName = item.Surname,
                    Email = item.Email,
                    Picture = item.Picture
                };
                appUserListModel.Add(model);
            }
            ViewBag.Personeller = appUserListModel;

            WorkListViewModel gorevModel = new WorkListViewModel
            {
                Id = work.Id,
                Name = work.Name,
                Description = work.Description,
                Profil = work.Profil,
                CreationDate = work.CreationDate,
                ProfilId = work.ProfilId
            };
            return View(gorevModel);
        }
    }
}
