namespace PersonalApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Despesas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valor = c.Double(nullable: false),
                        Data = c.String(),
                        UsuarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioID, cascadeDelete: true)
                .Index(t => t.UsuarioID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rendas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        ValorFixo = c.Double(nullable: false),
                        ValorVariavel = c.Double(nullable: false),
                        ValorOutros = c.Double(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioID, cascadeDelete: true)
                .Index(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rendas", "UsuarioID", "dbo.Usuarios");
            DropForeignKey("dbo.Despesas", "UsuarioID", "dbo.Usuarios");
            DropIndex("dbo.Rendas", new[] { "UsuarioID" });
            DropIndex("dbo.Despesas", new[] { "UsuarioID" });
            DropTable("dbo.Rendas");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Despesas");
        }
    }
}
