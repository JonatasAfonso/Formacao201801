namespace ConsoleTestDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteradoNomeTabela : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Localidades", newName: "Cidades");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Cidades", newName: "Localidades");
        }
    }
}
