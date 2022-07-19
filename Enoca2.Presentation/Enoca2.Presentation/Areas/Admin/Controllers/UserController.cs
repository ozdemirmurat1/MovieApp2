using Enoca2.Business.Abstract;
using Enoca2.Business.Helpers;
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
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IStringHelper _stringHelper;
        private readonly IUserTokenService _userTokenService;

        public UserController(IUserService userService, IStringHelper stringHelper, IUserTokenService userTokenService)
        {
            _userService = userService;
            _stringHelper = stringHelper;
            _userTokenService = userTokenService;
        }

        public IActionResult Index()
        {
            UserListViewModel model = new();
            model.UserList = _userService.List();
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var userId = _userService.GetById(id);
            _userService.Delete(userId);

            TempData.Put("message", new ResultMessage()
            {
                Title = "User Transactions",
                Message = "The User Has Been Successfully Deleted!",
                Css = "info"
            });

            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.Add(new User()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Password = _stringHelper.ToMd5(model.Password),
                    IsAdmin = model.IsAdmin,
                    Status = true
                });
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Student Transactions",
                    Message = "The Student Has Been Successfully Added!",
                    Css = "success"
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var user = _userService.GetById(id);
            UserViewModel model = new UserViewModel();
            model.Id = user.Id;
            model.UserName = user.UserName;
            model.Email = user.Email;
            model.Password = user.Password;
            model.IsAdmin = user.IsAdmin;
            model.Status = user.Status;

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    Id = model.Id,
                    UserName = model.UserName,
                    Email = model.Email,
                    Password = model.Password,
                    IsAdmin = model.IsAdmin,
                    Status = model.Status

                };
                _userService.Update(user);
                TempData.Put("message", new ResultMessage()
                {
                    Title = "Student Transactions",
                    Message = "The Student Has Been Successfully Edited!",
                    Css = "success"
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult UserTokenList()
        {

            UserTokenList userTokenList = new UserTokenList();
            userTokenList.List = _userTokenService.List();
            return View(userTokenList);
        }
        public IActionResult DeleteUserToken(int id)
        {
            var userToken = _userTokenService.GetById(id);
            _userTokenService.Delete(userToken);

            TempData.Put("message", new ResultMessage()
            {
                Title = "UserToken Transactions",
                Message = "The UserToken Has Been Successfully Deleted!",
                Css = "info"
            });

            return RedirectToAction("UserTokenList");
        }
    }
}
