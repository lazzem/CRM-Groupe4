using Data;
using Domain.Entities;
using ExamenWeb.Models;
using Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ExamenWeb.Controllers
{
    public class ProduitController : Controller
    {
        ServiceProduit sp = new ServiceProduit();
        ServiceCategorie sc = new ServiceCategorie();
        ServiceBoutique sb = new ServiceBoutique();


    
        // GET: Product
        public ActionResult ListeProduitFront()
        {
            var prods = sp.GetMany();
            return View(prods);
        }

        // GET: Product/Details/5
        public ActionResult DetailsFront(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produit p = sp.GetById((int)id);
            if (p == null)
            {
                return HttpNotFound();
            }
            return View(p);
        }




        //GET: Product
        public ActionResult ListeProduit()
        {
            ExamenContext db = new ExamenContext();

            ////List<Product> listprod = Session["Products"] as List<Product>;
            //var produit = sp.GetMany();

            return View(db.Produits.ToList());
        }

        [HttpPost]
        public ActionResult ListeProduit(String SearchString)
        {
            var produit = sp.GetMany(p => p.Nom.Contains(SearchString));
            return View(produit);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ProduitModel pm = new ProduitModel();
            //pour recupérer un  champ spécifique  Select(c=>c.name)
            pm.Categories = sc.GetMany().Select(c => new SelectListItem() { Text = c.Nom, Value = c.Id_categorie.ToString() });
            pm.Boutiques = sb.GetMany().Select(b => new SelectListItem() { Text = b.Nom, Value = b.Id_boutique.ToString() });

            return View(pm);
        }




        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProduitModel pm, HttpPostedFileBase Image)
        {
            pm.Image = Image.FileName;
            Produit p = new Produit()
            {
                Libelle = pm.Libelle,
                Nom = pm.Nom,
                Quantitee = pm.Quantitee,
                Prix = pm.Prix,
                Description = pm.Description,
                Image = pm.Image,
                Id_categorie = pm.Id_categorie,
                Id_boutique = pm.Id_boutique

            };


            var path = Path.Combine(Server.MapPath("~/Content/Upload/"), Image.FileName);
            Image.SaveAs(path);

        


            try
            {
                // TODO: Add insert logic here
                sp.Add(p);
                // listprod.Add(p);

                // Session["Products"] = listprod;

                sp.Commit();
                return RedirectToAction("ListeProduit");
            }
            catch
            {
                return View();
            }
        }



        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            sp.Commit();
            var produits = sp.GetById(id);
            return View(produits);

        }


        // GET: Produit/Delete/5
        public ActionResult Delete(int id)
        {
            var produits = sp.GetById(id);
            return View(produits);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var p = sp.GetById(id);
            try
            {
                // TODO: Add delete logic here

                sp.Delete(p);
                sp.Commit();


                return RedirectToAction("ListeProduit");
            }
            catch
            {
                return View();
            }
        }

        // POST: User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produit u = sp.GetById((int)id);
            if (u == null)
            {
                return HttpNotFound();
            }
            return View(u);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Produit u)
        {
            sp.Update(u);
            //db.Entry(avis).State = EntityState.Modified;

            return RedirectToAction("Index");
        }


    }
}