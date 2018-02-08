namespace ConsoleTestDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBaseDados : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Login = c.String(maxLength: 50),
                        Senha = c.String(maxLength: 10),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
