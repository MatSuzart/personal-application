namespace PersonalApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Secundary : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Despesas", "UsuarioID", "dbo.Usuarios");
            DropForeignKey("dbo.Rendas", "UsuarioID", "dbo.Usuarios");
            DropIndex("dbo.Despesas", new[] { "UsuarioID" });
            DropIndex("dbo.Rendas", new[] { "UsuarioID" });
            DropColumn("dbo.Despesas", "UsuarioID");
            DropColumn("dbo.Rendas", "UsuarioID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rendas", "UsuarioID", c => c.Int(nullable: false));
            AddColumn("dbo.Despesas", "UsuarioID", c => c.Int(nullable: false));
            CreateIndex("dbo.Rendas", "UsuarioID");
            CreateIndex("dbo.Despesas", "UsuarioID");
            AddForeignKey("dbo.Rendas", "UsuarioID", "dbo.Usuarios", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Despesas", "UsuarioID", "dbo.Usuarios", "ID", cascadeDelete: true);
        }
    }
}
