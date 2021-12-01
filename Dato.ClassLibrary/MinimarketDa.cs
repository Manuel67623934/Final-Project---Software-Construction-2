using Entidad.ClassLibrary;
using Microsoft.EntityFrameworkCore;

namespace Dato.ClassLibrary
{
    public class MinimarketDa : DbContext
    {
        public MinimarketDa(DbContextOptions<MinimarketDa> options) : base(options)
        {

        }
        public DbSet<CategoriaEntidad> Categoria { get; set; }
    }
}
