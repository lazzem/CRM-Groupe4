namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ex1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boutiques",
                c => new
                    {
                        Id_boutique = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Id_ville = c.Int(),
                        Zone = c.String(),
                        Service = c.String(),
                        Heure_ouverture = c.String(),
                        Heure_fermeture = c.String(),
                        Ascisse_X = c.Single(nullable: false),
                        Ordonné_Y = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id_boutique)
                .ForeignKey("dbo.Villes", t => t.Id_ville)
                .Index(t => t.Id_ville);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        Id_produit = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                        Nom = c.String(),
                        Prix = c.Single(nullable: false),
                        Quantitee = c.Int(nullable: false),
                        Description = c.String(),
                        Image = c.String(),
                        Id_categorie = c.Int(),
                        Id_boutique = c.Int(),
                    })
                .PrimaryKey(t => t.Id_produit)
                .ForeignKey("dbo.Boutiques", t => t.Id_boutique)
                .ForeignKey("dbo.Categories", t => t.Id_categorie)
                .Index(t => t.Id_categorie)
                .Index(t => t.Id_boutique);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id_categorie = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id_categorie);
            
            CreateTable(
                "dbo.Villes",
                c => new
                    {
                        Id_ville = c.Int(nullable: false, identity: true),
                        Ville_nom = c.String(),
                    })
                .PrimaryKey(t => t.Id_ville);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Boutiques", "Id_ville", "dbo.Villes");
            DropForeignKey("dbo.Produits", "Id_categorie", "dbo.Categories");
            DropForeignKey("dbo.Produits", "Id_boutique", "dbo.Boutiques");
            DropIndex("dbo.Produits", new[] { "Id_boutique" });
            DropIndex("dbo.Produits", new[] { "Id_categorie" });
            DropIndex("dbo.Boutiques", new[] { "Id_ville" });
            DropTable("dbo.Villes");
            DropTable("dbo.Categories");
            DropTable("dbo.Produits");
            DropTable("dbo.Boutiques");
        }
    }
}
