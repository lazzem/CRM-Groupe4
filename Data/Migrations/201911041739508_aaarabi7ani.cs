namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaarabi7ani : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produits", "Id_fichemobile", "dbo.FicheTechnique_Mobile");
            DropForeignKey("dbo.PacksProduits", "Packs_IdPack", "dbo.Packs");
            DropForeignKey("dbo.PacksProduits", "Produit_Id_produit", "dbo.Produits");
            DropForeignKey("dbo.Produits", "Panier_IdPanier", "dbo.Paniers");
            DropForeignKey("dbo.Paniers", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Commandes", "IdPanier", "dbo.Paniers");
            DropForeignKey("dbo.Commandes", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Complaints", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Devis", "IdPanier", "dbo.Paniers");
            DropForeignKey("dbo.Devis", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Newslettres", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Offres", "Products_Id_produit", "dbo.Produits");
            DropForeignKey("dbo.Promotions", "Products_Id_produit", "dbo.Produits");
            DropForeignKey("dbo.Publicites", "Produits_Id_produit", "dbo.Produits");
            DropIndex("dbo.Produits", new[] { "Id_fichemobile" });
            DropIndex("dbo.Produits", new[] { "Panier_IdPanier" });
            DropIndex("dbo.Commandes", new[] { "IdPanier" });
            DropIndex("dbo.Commandes", new[] { "IdUser" });
            DropIndex("dbo.Paniers", new[] { "IdUser" });
            DropIndex("dbo.Complaints", new[] { "IdUser" });
            DropIndex("dbo.Devis", new[] { "IdPanier" });
            DropIndex("dbo.Devis", new[] { "IdUser" });
            DropIndex("dbo.Newslettres", new[] { "IdUser" });
            DropIndex("dbo.Offres", new[] { "Products_Id_produit" });
            DropIndex("dbo.Promotions", new[] { "Products_Id_produit" });
            DropIndex("dbo.Publicites", new[] { "Produits_Id_produit" });
            DropIndex("dbo.PacksProduits", new[] { "Packs_IdPack" });
            DropIndex("dbo.PacksProduits", new[] { "Produit_Id_produit" });
            CreateTable(
                "dbo.Villes",
                c => new
                    {
                        Id_ville = c.Int(nullable: false, identity: true),
                        Ville_nom = c.String(),
                    })
                .PrimaryKey(t => t.Id_ville);
            
            AddColumn("dbo.Boutiques", "Id_ville", c => c.Int());
            AddColumn("dbo.Produits", "Prix", c => c.Single(nullable: false));
            CreateIndex("dbo.Boutiques", "Id_ville");
            AddForeignKey("dbo.Boutiques", "Id_ville", "dbo.Villes", "Id_ville");
            DropColumn("dbo.Boutiques", "Ville");
            DropColumn("dbo.Produits", "IdPack");
            DropColumn("dbo.Produits", "Id_fichemobile");
            DropColumn("dbo.Produits", "Panier_IdPanier");
            DropTable("dbo.Avis");
            DropTable("dbo.FicheTechnique_Mobile");
            DropTable("dbo.Packs");
            DropTable("dbo.Commandes");
            DropTable("dbo.Paniers");
            DropTable("dbo.Users");
            DropTable("dbo.Complaints");
            DropTable("dbo.Devis");
            DropTable("dbo.Newslettres");
            DropTable("dbo.Offres");
            DropTable("dbo.Promotions");
            DropTable("dbo.Publicites");
            DropTable("dbo.PacksProduits");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PacksProduits",
                c => new
                    {
                        Packs_IdPack = c.Int(nullable: false),
                        Produit_Id_produit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Packs_IdPack, t.Produit_Id_produit });
            
            CreateTable(
                "dbo.Publicites",
                c => new
                    {
                        IdPublicite = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Titre = c.String(),
                        Description = c.String(),
                        IdProduct = c.Int(),
                        Produits_Id_produit = c.Int(),
                    })
                .PrimaryKey(t => t.IdPublicite);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        IdPromotion = c.Int(nullable: false, identity: true),
                        IdProduit = c.Int(nullable: false),
                        NewPrice = c.Single(nullable: false),
                        Remise = c.Single(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        Products_Id_produit = c.Int(),
                    })
                .PrimaryKey(t => t.IdPromotion);
            
            CreateTable(
                "dbo.Offres",
                c => new
                    {
                        IdOffer = c.Int(nullable: false, identity: true),
                        IdProduit = c.Int(),
                        Image = c.String(),
                        Titee = c.String(),
                        Description = c.String(),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        Products_Id_produit = c.Int(),
                    })
                .PrimaryKey(t => t.IdOffer);
            
            CreateTable(
                "dbo.Newslettres",
                c => new
                    {
                        IdNewslettre = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(),
                        MailUser = c.String(),
                        PhoneUser = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdNewslettre);
            
            CreateTable(
                "dbo.Devis",
                c => new
                    {
                        IdDevis = c.Int(nullable: false, identity: true),
                        IdPanier = c.Int(),
                        IdUser = c.Int(),
                        PrixTotal = c.Single(nullable: false),
                        DateCommande = c.DateTime(nullable: false),
                        Status = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.IdDevis);
            
            CreateTable(
                "dbo.Complaints",
                c => new
                    {
                        ComplaintID = c.String(nullable: false, maxLength: 128),
                        Creation_date = c.DateTime(nullable: false),
                        Processing_date = c.DateTime(nullable: false),
                        Clossing_date = c.DateTime(nullable: false),
                        Type = c.String(),
                        Description = c.String(),
                        IdUser = c.Int(),
                    })
                .PrimaryKey(t => t.ComplaintID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        IdUser = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        login = c.String(),
                        Password = c.String(nullable: false),
                        Image = c.String(),
                        Function = c.String(),
                    })
                .PrimaryKey(t => t.IdUser);
            
            CreateTable(
                "dbo.Paniers",
                c => new
                    {
                        IdPanier = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(),
                        IdProduit = c.Int(),
                        Quantite = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPanier);
            
            CreateTable(
                "dbo.Commandes",
                c => new
                    {
                        IdCommande = c.Int(nullable: false, identity: true),
                        IdPanier = c.Int(nullable: false),
                        IdUser = c.Int(),
                        PrixTotal = c.Single(nullable: false),
                        DateCommand = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCommande);
            
            CreateTable(
                "dbo.Packs",
                c => new
                    {
                        IdPack = c.Int(nullable: false, identity: true),
                        IdProduit = c.Int(),
                        Image = c.String(),
                        Titre = c.String(),
                        Description = c.String(),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        Prix = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.IdPack);
            
            CreateTable(
                "dbo.FicheTechnique_Mobile",
                c => new
                    {
                        Id_fichemobile = c.Int(nullable: false, identity: true),
                        Marque = c.String(),
                        Dimensions = c.String(),
                        Poids = c.Single(nullable: false),
                        Ecrant = c.String(),
                        Definition = c.String(),
                        Photo = c.String(),
                        Os = c.String(),
                        Memoire_interne = c.String(),
                        Micro_sd = c.String(),
                        Connectivite = c.String(),
                        Nfc = c.String(),
                        Soc = c.String(),
                        Ram = c.String(),
                        Capteur_enpreintes = c.String(),
                        Resistance_eau = c.String(),
                        Batterie = c.Int(nullable: false),
                        Port_charge = c.String(),
                        Recharge_rapide = c.String(),
                        Recharge_sansfil = c.String(),
                        Coloris = c.String(),
                        Prix = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id_fichemobile);
            
            CreateTable(
                "dbo.Avis",
                c => new
                    {
                        IdView = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.IdView);
            
            AddColumn("dbo.Produits", "Panier_IdPanier", c => c.Int());
            AddColumn("dbo.Produits", "Id_fichemobile", c => c.Int());
            AddColumn("dbo.Produits", "IdPack", c => c.Int());
            AddColumn("dbo.Boutiques", "Ville", c => c.String());
            DropForeignKey("dbo.Boutiques", "Id_ville", "dbo.Villes");
            DropIndex("dbo.Boutiques", new[] { "Id_ville" });
            DropColumn("dbo.Produits", "Prix");
            DropColumn("dbo.Boutiques", "Id_ville");
            DropTable("dbo.Villes");
            CreateIndex("dbo.PacksProduits", "Produit_Id_produit");
            CreateIndex("dbo.PacksProduits", "Packs_IdPack");
            CreateIndex("dbo.Publicites", "Produits_Id_produit");
            CreateIndex("dbo.Promotions", "Products_Id_produit");
            CreateIndex("dbo.Offres", "Products_Id_produit");
            CreateIndex("dbo.Newslettres", "IdUser");
            CreateIndex("dbo.Devis", "IdUser");
            CreateIndex("dbo.Devis", "IdPanier");
            CreateIndex("dbo.Complaints", "IdUser");
            CreateIndex("dbo.Paniers", "IdUser");
            CreateIndex("dbo.Commandes", "IdUser");
            CreateIndex("dbo.Commandes", "IdPanier");
            CreateIndex("dbo.Produits", "Panier_IdPanier");
            CreateIndex("dbo.Produits", "Id_fichemobile");
            AddForeignKey("dbo.Publicites", "Produits_Id_produit", "dbo.Produits", "Id_produit");
            AddForeignKey("dbo.Promotions", "Products_Id_produit", "dbo.Produits", "Id_produit");
            AddForeignKey("dbo.Offres", "Products_Id_produit", "dbo.Produits", "Id_produit");
            AddForeignKey("dbo.Newslettres", "IdUser", "dbo.Users", "IdUser");
            AddForeignKey("dbo.Devis", "IdUser", "dbo.Users", "IdUser");
            AddForeignKey("dbo.Devis", "IdPanier", "dbo.Paniers", "IdPanier");
            AddForeignKey("dbo.Complaints", "IdUser", "dbo.Users", "IdUser");
            AddForeignKey("dbo.Commandes", "IdUser", "dbo.Users", "IdUser");
            AddForeignKey("dbo.Commandes", "IdPanier", "dbo.Paniers", "IdPanier", cascadeDelete: true);
            AddForeignKey("dbo.Paniers", "IdUser", "dbo.Users", "IdUser");
            AddForeignKey("dbo.Produits", "Panier_IdPanier", "dbo.Paniers", "IdPanier");
            AddForeignKey("dbo.PacksProduits", "Produit_Id_produit", "dbo.Produits", "Id_produit", cascadeDelete: true);
            AddForeignKey("dbo.PacksProduits", "Packs_IdPack", "dbo.Packs", "IdPack", cascadeDelete: true);
            AddForeignKey("dbo.Produits", "Id_fichemobile", "dbo.FicheTechnique_Mobile", "Id_fichemobile");
        }
    }
}
