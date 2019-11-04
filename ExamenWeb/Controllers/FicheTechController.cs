//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using Domain.Entities;
//using ExamenWeb.Models;

//namespace ExamenWeb.Controllers
//{
//    public class FicheTechController : Controller
//    {
//        private ApplicationDbContext db = new ApplicationDbContext();

//        // GET: FicheTech
//        public ActionResult Index()
//        {
//            return View(db.FicheTechnique_Mobile.ToList());
//        }

//        // GET: FicheTech/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            FicheTechnique_Mobile ficheTechnique_Mobile = db.FicheTechnique_Mobile.Find(id);
//            if (ficheTechnique_Mobile == null)
//            {
//                return HttpNotFound();
//            }
//            return View(ficheTechnique_Mobile);
//        }

//        // GET: FicheTech/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: FicheTech/Create
     
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id_fichemobile,Marque,Dimensions,Poids,Ecrant,Definition,Photo,Os,Memoire_interne,Micro_sd,Connectivite,Nfc,Soc,Ram,Capteur_enpreintes,Resistance_eau,Batterie,Port_charge,Recharge_rapide,Recharge_sansfil,Coloris,Prix")] FicheTechnique_Mobile ficheTechnique_Mobile)
//        {
//            if (ModelState.IsValid)
//            {
//                db.FicheTechnique_Mobile.Add(ficheTechnique_Mobile);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(ficheTechnique_Mobile);
//        }

//        // GET: FicheTech/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            FicheTechnique_Mobile ficheTechnique_Mobile = db.FicheTechnique_Mobile.Find(id);
//            if (ficheTechnique_Mobile == null)
//            {
//                return HttpNotFound();
//            }
//            return View(ficheTechnique_Mobile);
//        }

//        // POST: FicheTech/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id_fichemobile,Marque,Dimensions,Poids,Ecrant,Definition,Photo,Os,Memoire_interne,Micro_sd,Connectivite,Nfc,Soc,Ram,Capteur_enpreintes,Resistance_eau,Batterie,Port_charge,Recharge_rapide,Recharge_sansfil,Coloris,Prix")] FicheTechnique_Mobile ficheTechnique_Mobile)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(ficheTechnique_Mobile).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(ficheTechnique_Mobile);
//        }

//        // GET: FicheTech/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            FicheTechnique_Mobile ficheTechnique_Mobile = db.FicheTechnique_Mobile.Find(id);
//            if (ficheTechnique_Mobile == null)
//            {
//                return HttpNotFound();
//            }
//            return View(ficheTechnique_Mobile);
//        }

//        // POST: FicheTech/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            FicheTechnique_Mobile ficheTechnique_Mobile = db.FicheTechnique_Mobile.Find(id);
//            db.FicheTechnique_Mobile.Remove(ficheTechnique_Mobile);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
