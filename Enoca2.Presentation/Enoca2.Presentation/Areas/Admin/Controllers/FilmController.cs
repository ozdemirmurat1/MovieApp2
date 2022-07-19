using Enoca2.Business.Abstract;
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
    public class FilmController : Controller
    {
        private readonly IFilmService _filmService;
        private readonly IFilmHallService _filmHallService;

        public FilmController(IFilmService filmService, IFilmHallService filmHallService)
        {
            _filmService = filmService;
            _filmHallService = filmHallService;
        }

        public IActionResult Index()
        {
            FilmListViewModel model = new();
            model.List1 = _filmService.List();           
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var filmId = _filmService.GetById(id);
            _filmService.Delete(filmId);

            TempData.Put("message", new ResultMessage()
            {
                Title = "Film Transactions",
                Message = "The Film Has Been Successfully Deleted!",
                Css = "info"
            });

            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(FilmViewModel model)
        {
            if (ModelState.IsValid)
            {
                _filmService.Add(new Film()
                {
                    FilmName=model.FilmName,
                    FilmProductionYear=model.FilmProductionYear
                });
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Film Transactions",
                    Message = "The Film Has Been Successfully Added!",
                    Css = "success"
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var film = _filmService.GetById(id);
            FilmViewModel model = new FilmViewModel();
            model.Id = film.Id;
            model.FilmName = film.FilmName;
            model.FilmProductionYear = film.FilmProductionYear;
            

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(FilmViewModel model)
        {
            if (ModelState.IsValid)
            {
                Film film = new Film()
                {
                    Id = model.Id,
                    FilmName=model.FilmName,
                    FilmProductionYear=model.FilmProductionYear

                };
                _filmService.Update(film);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Film Transactions",
                    Message = "The Film Has Been Successfully Edited!",
                    Css = "success"
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult FilmHallList()
        {
            FilmHallListModel model = new FilmHallListModel();
            model.List = _filmHallService.List();
            return View(model);
        }
        public IActionResult DeleteFilmHall(int id)
        {
            var filmHallId = _filmHallService.GetById(id);
            _filmHallService.Delete(filmHallId);

            TempData.Put("message", new ResultMessage()
            {
                Title = "FilmHall Transactions",
                Message = "The FilmHall Has Been Successfully Deleted!",
                Css = "info"
            });

            return RedirectToAction("FilmHallList");
        }

        public IActionResult FilmHallAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FilmHallAdd(FilmHallViewModel model)
        {
            if (ModelState.IsValid)
            {
                _filmHallService.Add(new FilmHall()
                {
                    FilmId=model.FilmId,
                    HallId=model.HallId,
                    Sort=model.Sort
                });
                TempData.Put("message", new ResultMessage()
                {
                    Title = "FilmHall Transactions",
                    Message = "The FilmHall Has Been Successfully Added!",
                    Css = "success"
                });
                return RedirectToAction("FilmHallList");
            }
            return View(model);
        }
        public IActionResult EditFilmHall(int id)
        {
            var film = _filmHallService.GetById(id);
            FilmHallViewModel model = new FilmHallViewModel();
            model.Id = film.Id;
            model.FilmId = film.FilmId;
            model.HallId = film.HallId;
            model.Sort = film.Sort;

            return View(model);
        }

        [HttpPost]
        public IActionResult EditFilmHall(FilmHallViewModel model)
        {
            if (ModelState.IsValid)
            {
                FilmHall filmHall = new FilmHall()
                {
                    Id = model.Id,
                    FilmId=model.FilmId,
                    HallId=model.HallId,
                    Sort=model.Sort
                };
                _filmHallService.Update(filmHall);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "FilmHall Transactions",
                    Message = "The FilmHall Has Been Successfully Edited!",
                    Css = "success"
                });
                return RedirectToAction("FilmHallList");
            }
            return View(model);
        }

        public IActionResult GetFilmDetails(int? MinYear = null, int? MaxYear = null)
        {
            FilmDetailViewModel model = new();
            model.List = _filmService.GetFilmDetailByYear(MinYear, MaxYear);
            ViewBag.minYear = MinYear;
            ViewBag.maxYear = MaxYear;
            return View(model);
        }

        
    }
}
