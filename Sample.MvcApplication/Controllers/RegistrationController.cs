using DataAccessLayer;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.MvcApplication.Controllers
{
    public class RegistrationController : Controller
    {

        IRegistrationRepository reg = null;
        public RegistrationController(IConfiguration configuration, IRegistrationRepository regis)
        {
            reg = regis;
        }

        // GET: RegistrationController
        public ActionResult List()
        {
           var resutl =  reg.SelectALLUser();

            return View("list", resutl);
        }

        // GET: RegistrationController/Details/5
        public ActionResult Details(string username)
        {
            var edit = reg.SelectUserByUsername(username);

            return View("details", edit);
        }

        // GET: RegistrationController/Create
        public ActionResult Create()
        {
            return View("Add",new Registration());
        }

        // POST: RegistrationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Registration regis)
        {
            try
            {
                reg.RegisterUser(regis);

                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistrationController/Edit/5
        public ActionResult Edit(string username)
        {
            var edit = reg.SelectUserByUsername(username);

            return View("update", edit);
        }

        // POST: RegistrationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Registration regis)
        {
            try
            {
                reg.UpdateUser(regis);

                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistrationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistrationController/Delete/5
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
