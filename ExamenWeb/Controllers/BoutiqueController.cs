using System.Linq;
using Services;
using System.Web.Mvc;
using ExamenWeb.Models;
using Domain.Entities;

namespace ExamenWeb.Controllers
{
    public class BoutiqueController : Controller
    {
        ServiceBoutique sb = new ServiceBoutique();
        ServiceVille sv = new ServiceVille();

        // GET: Boutique
        public ActionResult ListeBoutique()
        {
            var boutique = sb.GetMany();
            return View(boutique);
        }

        // GET: Boutique/Details/5
        public ActionResult Details(int id)
        {
            var categorie = sb.GetById(id);
            return View(categorie);
        }

        // GET: Boutique/Create
        public ActionResult Create()
        {
            BoutiqueModel bm = new BoutiqueModel();
            //pour recupérer un  champ spécifique  Select(c=>c.name)
            bm.Villes = sv.GetMany().Select(c => new SelectListItem() { Text = c.Ville_nom, Value = c.Id_ville.ToString() });

            return View(bm);
        }

        // POST: Boutique/Create
        [HttpPost]
        public ActionResult Create(BoutiqueModel bm)
        {
            Boutique b = new Boutique()
            {
                Nom = bm.Nom,
                Phone = bm.Phone,
                Email = bm.Email,
                Id_ville = bm.Id_ville,
                Zone = bm.Zone,
                Service = bm.Service,
                Heure_ouverture = bm.Heure_ouverture,
                Heure_fermeture = bm.Heure_fermeture,
                Ascisse_X = bm.Ascisse_X,
                Ordonné_Y = bm.Ordonné_Y

            };
            try
            {
                // TODO: Add insert logic here
                sb.Add(b);
                // listprod.Add(p);

                // Session["Products"] = listprod;

                sb.Commit();
                return RedirectToAction("ListeBoutique");
            }
            catch
            {
                return View();
            }
        }

        // GET: Boutique/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Boutique/Edit/5
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

        // GET: Boutique/Delete/5
        public ActionResult Delete(int id)
        {
            var boutique = sb.GetById(id);
            return View(boutique);
        }

        // POST: Boutique/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var b = sb.GetById(id);
            try
            {
                sb.Delete(b);
                sb.Commit();

                return RedirectToAction("ListeBoutique");
            }
            catch
            {
                return View();
            }
        }
    }
}
