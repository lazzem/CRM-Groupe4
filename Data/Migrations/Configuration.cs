namespace Data.Migrations
{
    using Domain.Entities;
    using Domaine.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.ExamenContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

        }

        protected override void Seed(Data.ExamenContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

        
            context.Categories.AddOrUpdate(c => c.Nom, new Categorie()
            { Nom = "légume" }, new Categorie()
            { Nom = "fruit" }, new Categorie()
            { Nom = "meuble" }
              );

            context.Villes.AddOrUpdate(c => c.Ville_nom,
                new Ville() { Ville_nom = "Ariana" }, 
                new Ville() { Ville_nom = "Béja" },
                new Ville() { Ville_nom = "Ben Arous" },
                new Ville() { Ville_nom = "Bizerte" },
                new Ville() { Ville_nom = "Gabes" },
                new Ville() { Ville_nom = "Gafsa" },
                new Ville() { Ville_nom = "Jendouba" },
                new Ville() { Ville_nom = "Kairouan" },
                new Ville() { Ville_nom = "Kasserine" },
                new Ville() { Ville_nom = "Kebili" },
                new Ville() { Ville_nom = "La Manouba" },
                new Ville() { Ville_nom = "Le Kef" },
                new Ville() { Ville_nom = "Mahdia" },
                new Ville() { Ville_nom = "Médenine" },
                new Ville() { Ville_nom = "Monastir" },
                new Ville() { Ville_nom = "Nabeul" },
                new Ville() { Ville_nom = "Sfax" },
                new Ville() { Ville_nom = "Sidi Bouzid" },
                new Ville() { Ville_nom = "Siliana" },
                new Ville() { Ville_nom = "Sousse" },
                new Ville() { Ville_nom = "Tataouine" },
                new Ville() { Ville_nom = "Tozeur" },
                new Ville() { Ville_nom = "Tunis" },
                new Ville() { Ville_nom = "Zaghouan" }
              );
        }
    }
    
}
