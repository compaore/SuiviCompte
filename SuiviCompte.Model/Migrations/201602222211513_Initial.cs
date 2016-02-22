namespace SuiviCompte.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ecritures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Montant = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Commentaire = c.String(),
                        Nature_Id = c.String(maxLength: 128),
                        Sens_Code = c.String(maxLength: 1),
                        TypeEcriture_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NatureEcritures", t => t.Nature_Id)
                .ForeignKey("dbo.SensEcritures", t => t.Sens_Code)
                .ForeignKey("dbo.TypeEcritures", t => t.TypeEcriture_Id)
                .Index(t => t.Nature_Id)
                .Index(t => t.Sens_Code)
                .Index(t => t.TypeEcriture_Id);
            
            CreateTable(
                "dbo.NatureEcritures",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Libelle = c.String(maxLength: 255),
                        Commentaire = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SensEcritures",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 1),
                        Libelle = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.TypeEcritures",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Libelle = c.String(maxLength: 255),
                        Commentaire = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ecritures", "TypeEcriture_Id", "dbo.TypeEcritures");
            DropForeignKey("dbo.Ecritures", "Sens_Code", "dbo.SensEcritures");
            DropForeignKey("dbo.Ecritures", "Nature_Id", "dbo.NatureEcritures");
            DropIndex("dbo.Ecritures", new[] { "TypeEcriture_Id" });
            DropIndex("dbo.Ecritures", new[] { "Sens_Code" });
            DropIndex("dbo.Ecritures", new[] { "Nature_Id" });
            DropTable("dbo.TypeEcritures");
            DropTable("dbo.SensEcritures");
            DropTable("dbo.NatureEcritures");
            DropTable("dbo.Ecritures");
        }
    }
}
