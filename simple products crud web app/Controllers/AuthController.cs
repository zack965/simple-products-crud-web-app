using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simple_products_crud_web_app.Models;
using simple_products_crud_web_app.Models.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_products_crud_web_app.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthInterface<AuthorDependency> authores;

        public AuthController(IAuthInterface<AuthorDependency> authores)
        {
            this.authores = authores;
        }
        // GET: AuthController
        public ActionResult Index_auth()
        {
            var aurh = authores.List();
            return View(aurh);
        }

        // GET: AuthController/Details/5
        public ActionResult Details_auth(int id)
        {
            var auth = authores.Find(id);
            return View(auth);
        }

        // GET: AuthController/Create
        public ActionResult Create_auth()
        {
            return View();
        }

        // POST: AuthController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create_auth(AuthorDependency aurho)
        {
            try
            {
                authores.Add(aurho);
              
                return RedirectToAction(nameof(Index_auth));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthController/Edit/5
        public ActionResult Edit_auth(int id)
        {
            var auth = authores.Find(id);
            return View(auth);
        }

        // POST: AuthController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_auth(int id, AuthorDependency autho)
        {
            try
            {
                authores.Update(id,autho);
                return RedirectToAction(nameof(Index_auth));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthController/Delete/5
        public ActionResult Delete_auth(int id)
        {
            var auth = authores.Find(id);
            return View(auth);
        }

        // POST: AuthController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_auth(AuthorDependency autho)
        {
            try
            {
                authores.Delete(autho);
                return RedirectToAction(nameof(Index_auth));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Search_Auth(int id)
        {
            var auth = authores.Find(id);
            return View(auth);
        }
    }
}
