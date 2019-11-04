using Domain.Entities;
using Domaine.Entities;
using System.Data.Entity;
using System;

namespace Data
{
    public  class ExamenContext : DbContext
    {
        public ExamenContext() : base("Name=alias")
        {
            
        }
        //public DbSet<User> Users { get; set; }
          public DbSet<Boutique> Boutiques { get; set; }
          public DbSet<Categorie> Categories { get; set; }
          public DbSet<Ville> Villes { get; set; }
        //public DbSet<Commande> Commandes { get; set; }
        //public DbSet<Devis> Deviss { get; set; }
        //public DbSet<FicheTechnique_Mobile> Fiches { get; set; }
        //public DbSet<Newslettre> Newslettres { get; set; }
        //public DbSet<Offre> Offres { get; set; }
        //public DbSet<Packs> Packss { get; set; }
        //public DbSet<Panier> Paniers { get; set; }
        public DbSet<Produit> Produits { get; set; }

        //public DbSet<Promotion> Promotions { get; set; }
        //public DbSet<Publicite> Publicites { get; set; }
        //public DbSet<Avis> Aviss { get; set; }
        //public DbSet<Complaint> Complaints { get; set; }

    }
}
