using System.Data.Entity;

namespace MigraPlastifluor
{
    public class Context : DbContext
    {
        public Context() : base("name=SqlServer")
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ClasseCusto> ClasseCustos { get; set; }
        public DbSet<Familia> Familias { get; set; }
        public DbSet<GrupoRateio> GrupoRateios { get; set; }
        public DbSet<Linha> Linhas { get; set; }
        public DbSet<LogData> LogData { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
    }
}
