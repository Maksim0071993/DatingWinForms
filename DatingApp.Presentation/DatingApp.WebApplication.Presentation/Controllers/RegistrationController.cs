using DatingApp.BusinesLogic.Services;
using DatingApp.WebApplication.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.WebApplication.Presentation.Controllers
{
    public class RegistrationController : Controller
    {
        RegistrationService _registrationService = new RegistrationService();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add( RegistrationViewModel model)
        {
            _registrationService.Register(model.Email, model.UserPassword);
            return RedirectToAction("Index");
        }
    }
}
