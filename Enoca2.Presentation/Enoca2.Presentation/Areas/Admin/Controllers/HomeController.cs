using Enoca2.Business.Abstract;
using Enoca2.Business.Helpers;
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
    public class HomeController : Controller
    {
        private readonly ICookieHelper _cookieHelper;
        private readonly IUserService _userService;
        private readonly IUserTokenService _userTokenService;

        public HomeController(ICookieHelper cookieHelper, IUserService userService, IUserTokenService userTokenService)
        {
            _cookieHelper = cookieHelper;
            _userService = userService;
            _userTokenService = userTokenService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminLoginModel model)
        {
            if (ModelState.IsValid)
            {
                var login = _userService.AdminLogin(model.Email, model.Password);
                if (login == null)
                {
                    ModelState.AddModelError("Login Error", "Giriş Başarısız");
                }
                else
                {
                    string guid = Guid.NewGuid().ToString();
                    _cookieHelper.Add(CookieTypes.admin, guid, DateTime.Now.AddDays(10), Response);
                    _userTokenService.Add(guid, login.Id);

                    TempData.Put("message", new ResultMessage()
                    {
                        Title = "Login Transactions",
                        Message = "You Have Been Securely Logged Into The Admin Panel",
                        Css = "success"

                    });

                    return RedirectToAction("Index", "Dashboard");



                }
            }
            else
            {
                // incorrect model
            }
            return View();
        }
    }
}
