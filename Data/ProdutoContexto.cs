using Microsoft.EntityFrameworkCore;

namespace RPH.API.Data
{
    public class ProdutoContexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public ProdutoContexto(DbContextOptions options) 
            : base (options)
        {

        }
    }
}