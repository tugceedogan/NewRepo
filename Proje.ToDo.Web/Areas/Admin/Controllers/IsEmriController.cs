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
                WorkListAllViewModel model = new WorkListAllViewModel();
                model.Id = item.Id;
                model.Description = item.Description;
                model.Aciliyet = item.Aciliyet;
                model.Name = item.Name;
                model.AppUser = item.AppUser;
                model.CreationDate = item.CreationDate;
                model.Raporlar = item.Raporlar;
                models.Add(model);
            }
            return View(models);
        }

        public IActionResult AtaPersonel(int id,string s,int sayfa=1)
        {
            TempData["Active"] = "isemri";
            ViewBag.AktifSayfa = sayfa;

            ViewBag.Aranan = s;

            int toplamSayfa;
            var work = _workService.GetirAciliyetIleId(id);

            //ViewBag.ToplamSayfa =(int)Math.Ceiling((double) _appUserService.GetNotAdmin().Count/3);

            var personeller = _appUserService.GetNotAdmin(out toplamSayfa,s,sayfa);
            ViewBag.ToplamSayfa = toplamSayfa;

            List<AppUserListViewModel> appUserListModel = new List<AppUserListViewModel>();
            foreach(var item in personeller)
            {
                AppUserListViewModel model = new AppUserListViewModel();
                model.Id = item.Id;
                model.Name = item.Name;
                model.SurName = item.Surname;
                model.Email = item.Email;
                model.Picture = item.Picture;
                appUserListModel.Add(model);
            }
            ViewBag.Personeller = appUserListModel;

            WorkListViewModel gorevModel = new WorkListViewModel();
            gorevModel.Id = work.Id;
            gorevModel.Name = work.Name;
            gorevModel.Description = work.Description;
            gorevModel.Aciliyet = work.Aciliyet;
            gorevModel.CreationDate = work.CreationDate;
            gorevModel.AciliyetId = work.AciliyetId;
            return View(gorevModel);
        }
    }
}
