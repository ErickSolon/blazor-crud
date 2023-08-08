using Microsoft.EntityFrameworkCore;
using Projeto.Models;


namespace Projeto.Data
{
    public class ProjetoDbContext : DbContext
    {
        public DbSet<Pessoas> PessoasModel { get; set; }

        public ProjetoDbContext(DbContextOptions<ProjetoDbContext> options) : base(options)
        {

        }
    }
}