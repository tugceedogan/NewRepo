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
    public class ProfilController : Controller
    {
        private readonly IProfilService _profilService;
        public ProfilController(IProfilService profilService)
        {
            _profilService = profilService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "profil";
            List<Profil> profils = _profilService.GetAll();
            List<ProfilListViewModel> model = new List<ProfilListViewModel>();
            foreach (var item in profils)
            {
                ProfilListViewModel profilModel = new ProfilListViewModel();
                profilModel.Id = item.Id;
                profilModel.Tanim = item.Tanim;

                model.Add(profilModel);
            }
            return View(model);
        }
        public IActionResult EkleAciliyet()
        {
            TempData["Active"] = "profil";
            return View(new ProfilAddViewModel());
        }
        [HttpPost]
        public IActionResult EkleAciliyet(ProfilAddViewModel model)
        {
            TempData["Active"] = "profil";
            if (ModelState.IsValid)
            {
                _profilService.Save(new Profil()
                {
                    Tanim = model.Tanim
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult GuncelleAciliyet(int id)
        {
            TempData["Active"] = "profil";
            var profil = _profilService.GetIdWithOne(id);
            ProfilUpdateViewModel model = new ProfilUpdateViewModel
            {
                Id = profil.Id,
                Tanim = profil.Tanim
            };
            return View(model);
        }


        [HttpPost]
        public IActionResult GuncelleAciliyet(ProfilUpdateViewModel model)
        {
            TempData["Active"] = "profil";
            if (ModelState.IsValid)
            {
                _profilService.Update(new Profil
                {
                    Id = model.Id,
                    Tanim = model.Tanim
                 });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
