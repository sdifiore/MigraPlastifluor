namespace MigraPlastifluor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Apelido = c.String(maxLength: 2),
                        Descricao = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.ClasseCustoes",
                c => new
                    {
                        ClasseCustoId = c.Int(nullable: false, identity: true),
                        Apelido = c.String(maxLength: 2),
                        Descricao = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ClasseCustoId);
            
            CreateTable(
                "dbo.Familias",
                c => new
                    {
                        FamiliaId = c.Int(nullable: false, identity: true),
                        Apelido = c.String(maxLength: 3),
                        Descricao = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.FamiliaId);
            
            CreateTable(
                "dbo.GrupoRateios",
                c => new
                    {
                        GrupoRateioId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.GrupoRateioId);
            
            CreateTable(
                "dbo.Linhas",
                c => new
                    {
                        LinhaId = c.Int(nullable: false, identity: true),
                        Apelido = c.String(maxLength: 4),
                        Descricao = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.LinhaId);
            
            CreateTable(
                "dbo.LogData",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Timestamp = c.DateTime(nullable: false),
                        Reason = c.String(nullable: false, maxLength: 5),
                        Message = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 10),
                        Descricao = c.String(maxLength: 100),
                        UnidadeId = c.Int(nullable: false),
                        TipoId = c.Int(nullable: false),
                        ClasseCustoId = c.Int(nullable: false),
                        FamiliaId = c.Int(nullable: false),
                        LinhaId = c.Int(nullable: false),
                        GrupoRateioId = c.Int(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.ClasseCustoes", t => t.ClasseCustoId, cascadeDelete: true)
                .ForeignKey("dbo.Familias", t => t.FamiliaId, cascadeDelete: true)
                .ForeignKey("dbo.GrupoRateios", t => t.GrupoRateioId, cascadeDelete: true)
                .ForeignKey("dbo.Linhas", t => t.LinhaId, cascadeDelete: true)
                .ForeignKey("dbo.Tipoes", t => t.TipoId, cascadeDelete: true)
                .ForeignKey("dbo.Unidades", t => t.UnidadeId, cascadeDelete: true)
                .Index(t => t.UnidadeId)
                .Index(t => t.TipoId)
                .Index(t => t.ClasseCustoId)
                .Index(t => t.FamiliaId)
                .Index(t => t.LinhaId)
                .Index(t => t.GrupoRateioId)
                .Index(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Tipoes",
                c => new
                    {
                        TipoId = c.Int(nullable: false, identity: true),
                        Apelido = c.String(maxLength: 1),
                        Descricao = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.TipoId);
            
            CreateTable(
                "dbo.Unidades",
                c => new
                    {
                        UnidadeId = c.Int(nullable: false, identity: true),
                        Apelido = c.String(maxLength: 2),
                        Descricao = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.UnidadeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "UnidadeId", "dbo.Unidades");
            DropForeignKey("dbo.Produtoes", "TipoId", "dbo.Tipoes");
            DropForeignKey("dbo.Produtoes", "LinhaId", "dbo.Linhas");
            DropForeignKey("dbo.Produtoes", "GrupoRateioId", "dbo.GrupoRateios");
            DropForeignKey("dbo.Produtoes", "FamiliaId", "dbo.Familias");
            DropForeignKey("dbo.Produtoes", "ClasseCustoId", "dbo.ClasseCustoes");
            DropForeignKey("dbo.Produtoes", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtoes", new[] { "CategoriaId" });
            DropIndex("dbo.Produtoes", new[] { "GrupoRateioId" });
            DropIndex("dbo.Produtoes", new[] { "LinhaId" });
            DropIndex("dbo.Produtoes", new[] { "FamiliaId" });
            DropIndex("dbo.Produtoes", new[] { "ClasseCustoId" });
            DropIndex("dbo.Produtoes", new[] { "TipoId" });
            DropIndex("dbo.Produtoes", new[] { "UnidadeId" });
            DropTable("dbo.Unidades");
            DropTable("dbo.Tipoes");
            DropTable("dbo.Produtoes");
            DropTable("dbo.LogData");
            DropTable("dbo.Linhas");
            DropTable("dbo.GrupoRateios");
            DropTable("dbo.Familias");
            DropTable("dbo.ClasseCustoes");
            DropTable("dbo.Categorias");
        }
    }
}
