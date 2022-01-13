using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class WorkController : Controller
    {
        private readonly IWorkService _workService;
        private readonly IProfilService _profilService;
        public WorkController(IWorkService workService,IProfilService profilService)
        {
            _profilService = profilService;
            _workService = workService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "work";
            List<Work> works = _workService.GetirProfilIleTamamlanmayan();
            List<WorkListViewModel> models = new List<WorkListViewModel>();
            foreach (var item in works)
            {
                WorkListViewModel model = new WorkListViewModel
                {
                    Description = item.Description,
                    Profil = item.Profil,
                    ProfilId = item.ProfilId,
                    Name = item.Name,
                    State = item.State,
                    Id = item.Id,
                    CreationDate = item.CreationDate
                };
                models.Add(model);
            }
            return View(models);
        }

        public IActionResult EkleWork()
        {
            TempData["Active"] = "work";
            ViewBag.Aciliyetler = new SelectList(_profilService.GetAll(),"Id","Tanim");
            return View(new WorkAddViewModel());
        }

        [HttpPost]
        public IActionResult EkleWork(WorkAddViewModel model)
        {
            TempData["Active"] = "work";
            if (ModelState.IsValid)
            {
                _workService.Save(new Work
                {
                    Description = model.Description,
                    Name= model.Name,
                    ProfilId=model.ProfilId,
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult GuncelleWork(int id)
        {
            TempData["Active"] = "work";
            var work= _workService.GetIdWithOne(id);
            WorkUpdateViewModel model = new WorkUpdateViewModel
            {
                Id = work.Id,
                Description = work.Description,
                ProfilId = work.ProfilId,
                Name = work.Name
            };
            ViewBag.Profils = new SelectList(_profilService.GetAll(), "Id", "Tanim",work.ProfilId);
            return View(model);

        }

        [HttpPost]
        public IActionResult GuncelleWork (WorkUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                _workService.Update(new Work()
                {
                    Id = model.Id,
                    Description = model.Description,
                    ProfilId = model.ProfilId,
                    Name = model.Name,

                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult DeleteWork(int id)
        {
            _workService.Delete(new Work { Id = id });
            return Json(null);
        }
    }
}
