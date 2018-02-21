namespace ConsoleTestDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteradoTamanhoCampoSenha : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(maxLength: 32));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(maxLength: 10));
        }
    }
}
