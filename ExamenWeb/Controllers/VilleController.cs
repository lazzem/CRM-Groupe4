using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenWeb.Controllers
{
    public class VilleController : Controller
    {
        ServiceVille sv = new ServiceVille();

        // GET: Ville
        public ActionResult Index()
        {
           
            //List<Product> listprod = Session["Products"] as List<Product>;
            var ville = sv.GetMany();
            return View(ville);
        }

        // GET: Ville/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ville/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ville/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ville/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ville/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ville/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ville/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
