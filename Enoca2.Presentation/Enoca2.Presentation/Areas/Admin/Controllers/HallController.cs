using Enoca2.Business.Abstract;
using Enoca2.DataAccess.Abstract;
using Enoca2.Entities.Concrete;
using Enoca2.Presentation.Areas.Admin.Extensions;
using Enoca2.Presentation.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enoca2.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HallController : Controller
    {
        private readonly IHallService _hallService;

        public HallController(IHallService hallService)
        {
            _hallService = hallService;
        }

        public IActionResult Index()
        {
            HallListViewModel model = new();
            model.List = _hallService.List();
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            var hallId = _hallService.GetById(id);
            _hallService.Delete(hallId);

            TempData.Put("message", new ResultMessage()
            {
                Title = "Hall Transactions",
                Message = "The Hall Has Been Successfully Deleted!",
                Css = "info"
            });

            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(HallViewModel model)
        {
            if (ModelState.IsValid)
            {
                _hallService.Add(new Hall()
                {
                    HallName=model.HallName
                });
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Hall Transactions",
                    Message = "The Hall Has Been Successfully Added!",
                    Css = "success"
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var hall = _hallService.GetById(id);
            HallViewModel model = new HallViewModel();
            model.Id = hall.Id;
            model.HallName = hall.HallName;            

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(HallViewModel model)
        {
            if (ModelState.IsValid)
            {
                Hall hall = new Hall()
                {
                    Id = model.Id,
                    HallName=model.HallName

                };
                _hallService.Update(hall);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Hall Transactions",
                    Message = "The Hall Has Been Successfully Edited!",
                    Css = "success"
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
