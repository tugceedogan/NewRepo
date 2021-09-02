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
    [Area("Admin")]
    public class WorkController : Controller
    {
        private readonly IWorkService _workService;
        private readonly IAciliyetService _aciliyetService;
        public WorkController(IWorkService workService,IAciliyetService aciliyetService)
        {
            _aciliyetService = aciliyetService;
            _workService = workService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "work";
            List<Work> works = _workService.GetirAciliyetIleTamamlanmayan();
            List<WorkListViewModel> models = new List<WorkListViewModel>();
            foreach (var item in works)
            {
                WorkListViewModel model = new WorkListViewModel
                {
                    Description = item.Description,
                    Aciliyet = item.Aciliyet,
                    AciliyetId = item.AciliyetId,
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
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetAll(),"Id","Tanim");
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
                    AciliyetId=model.AciliyetId,
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
                AciliyetId = work.AciliyetId,
                Name = work.Name
            };
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetAll(), "Id", "Tanim",work.AciliyetId);
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
                    AciliyetId = model.AciliyetId,
                    Name = model.Name,

                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
