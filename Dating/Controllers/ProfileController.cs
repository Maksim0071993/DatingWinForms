using Dating.Data;
using Dating.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;




namespace Dating.Controllers
{
    public class ProfileController : Controller
    {
        private ApplicationDbContext db;
        public ProfileController(ApplicationDbContext context)
        {
            db = context;
        }

        // GET: ProfileController/5
        public ActionResult List(string search, int? age)
        {
            var profiles = db.Profiles.AsQueryable();
            if (search != null && search != string.Empty)
            {
                profiles = profiles.Where(p => p.FirstName.Contains(search) || p.LastName.Contains(search));
            }
            if (age != null && age > 0)
            {
                profiles = profiles.Where(p => p.Age >= age.Value) ;
            }
            return View(profiles.ToList());
        }

        // GET: ProfileController/5
        public ActionResult Index(int id)
        {
            var x = db.Profiles.Find(new object[] { id });
            return View(x);
        }

        // GET: ProfileController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfileController/Create
        [HttpPost]
        public ActionResult Create(Profile profile, IFormFile upload)
        {
            try
            {
                if (upload != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        upload.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        profile.Image = Convert.ToBase64String(fileBytes);
                    }
                }
                db.Profiles.Add(profile);
                db.SaveChanges();
            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index", "Profile", new { id = profile.Id });
        }

        // GET: ProfileController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfileController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfileController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfileController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
