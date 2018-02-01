namespace ConsoleTestDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadaTabelaMedico : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        NumeroCelula = c.String(),
                        CidadeId = c.Int(nullable: false),
                        EspecialidadeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidades", t => t.CidadeId, cascadeDelete: true)
                .ForeignKey("dbo.Especialidades", t => t.EspecialidadeId, cascadeDelete: true)
                .Index(t => t.CidadeId)
                .Index(t => t.EspecialidadeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medicos", "EspecialidadeId", "dbo.Especialidades");
            DropForeignKey("dbo.Medicos", "CidadeId", "dbo.Cidades");
            DropIndex("dbo.Medicos", new[] { "EspecialidadeId" });
            DropIndex("dbo.Medicos", new[] { "CidadeId" });
            DropTable("dbo.Medicos");
        }
    }
}
