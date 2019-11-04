using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Domain.Entities;
using ExamenWeb.Models;
using Services;
using System.IO;

namespace ExamenWeb.Controllers
{
    public class CategorieController : Controller
    {
        ServiceCategorie sc = new ServiceCategorie();

        // GET: Categorie
        public ActionResult ListeCategorie()
        {
            var categorie = sc.GetMany();
            return View(categorie);

        }

       

        // GET: Categorie/Create
        public ActionResult Create()
        {
            CategorieModel cm = new CategorieModel();
            //pour recupérer un  champ spécifique  Select(c=>c.name)

            return View(cm);
        }

        // POST: Categorie/Create
        [HttpPost]
        public ActionResult Create(CategorieModel cm)
        {
            
            Categorie c = new Categorie()
            {
                Nom = cm.Nom
            };

            

            // List<Categorie> listcat = Session["Categories"] as List<Categorie>;
            //if (listcat == null)
            //{
            //    listcat = new List<Categorie>();

            //}

            try
            {
                sc.Add(c);
                // TODO: Add insert logic here
                sc.Commit();
                return RedirectToAction("ListeCategorie");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var categorie = sc.GetById(id);
            return View(categorie);

        }
        // GET: Produit/Delete/5
        public ActionResult Delete(int id)
        {
            var categorie = sc.GetById(id);
            return View(categorie);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var p = sc.GetById(id);
            try
            {
                // TODO: Add delete logic here

                sc.Delete(p);
                sc.Commit();


                return RedirectToAction("ListeCategorie");
            }
            catch
            {
                return View();
            }
        }


        //// GET: Product/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    var categorie = sc.GetById(id);
        //    return View(categorie);
        //}

        //// POST: Product/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    var p = sc.GetById(id);
        //    CategorieModel cm = new CategorieModel();
        //    Categorie c = new Categorie()
        //    {
        //        Nom = cm.Nom
        //    };
        //    try
        //    {
        //        sc.Add(c);
        //        // TODO: Add insert logic here
        //        sc.Commit();
        //        return RedirectToAction("ListeCategorie");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categorie c = sc.GetById((int)id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categorie c)
        {
           
            sc.Update(c);

            sc.Commit();
            return RedirectToAction("ListeCategorie");
        }




    }
}


