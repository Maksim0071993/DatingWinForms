using DatingApp.BusinesLogic.Services;
using DatingApp.WebApplication.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.WebApplication.Presentation.Controllers
{
    public class LoginController : Controller
    {
        LoginService _loginService = new LoginService();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SearchUser(RegistrationViewModel model)
        {
            _loginService.SearchUser(model.Email, model.UserPassword);           
            return RedirectToAction("Index");
        }
        
    }
}
