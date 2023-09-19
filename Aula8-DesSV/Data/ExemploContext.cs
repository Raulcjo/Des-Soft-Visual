using Aula8_DesSV.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula8_DesSV.Data
{
    public class ExemploContext : DbContext
    {
        //Construtor
        public ExemploContext(DbContextOptions<ExemploContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }

    }
}
