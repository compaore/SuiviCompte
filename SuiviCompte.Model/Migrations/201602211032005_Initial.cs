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
                        Nature_Code = c.String(maxLength: 1),
                        Sens_Id = c.String(maxLength: 128),
                        TypeEcriture_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NATURE_ECRITURE", t => t.Nature_Code)
                .ForeignKey("dbo.SensEcritures", t => t.Sens_Id)
                .ForeignKey("dbo.TypeEcritures", t => t.TypeEcriture_Id)
                .Index(t => t.Nature_Code)
                .Index(t => t.Sens_Id)
                .Index(t => t.TypeEcriture_Id);
            
            CreateTable(
                "dbo.NATURE_ECRITURE",
                c => new
                    {
                        CODE = c.String(nullable: false, maxLength: 1),
                        LIBELLE = c.String(),
                        COMMENTAIRE = c.String(),
                    })
                .PrimaryKey(t => t.CODE);
            
            CreateTable(
                "dbo.SensEcritures",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Libelle = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeEcritures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                        Commentaire = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ecritures", "TypeEcriture_Id", "dbo.TypeEcritures");
            DropForeignKey("dbo.Ecritures", "Sens_Id", "dbo.SensEcritures");
            DropForeignKey("dbo.Ecritures", "Nature_Code", "dbo.NATURE_ECRITURE");
            DropIndex("dbo.Ecritures", new[] { "TypeEcriture_Id" });
            DropIndex("dbo.Ecritures", new[] { "Sens_Id" });
            DropIndex("dbo.Ecritures", new[] { "Nature_Code" });
            DropTable("dbo.TypeEcritures");
            DropTable("dbo.SensEcritures");
            DropTable("dbo.NATURE_ECRITURE");
            DropTable("dbo.Ecritures");
        }
    }
}
