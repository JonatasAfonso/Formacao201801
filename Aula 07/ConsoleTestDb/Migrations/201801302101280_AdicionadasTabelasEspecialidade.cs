namespace ConsoleTestDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadasTabelasEspecialidade : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Localidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Especialidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Especialidades");
            DropTable("dbo.Localidades");
        }
    }
}
