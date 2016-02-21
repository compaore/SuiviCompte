namespace SuiviCompte.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropAll : DbMigration
    {
        public override void Up()
        {
            DropTable("Ecritures");
            DropTable("NATURE_ECRITURE");
            DropTable("SensEcritures");
            DropTable("TypeEcritures");
        }
        
        public override void Down()
        {
        }
    }
}
