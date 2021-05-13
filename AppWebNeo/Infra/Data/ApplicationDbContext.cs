using AppWebNeo.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWebNeo.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Contato> Contatos { get; set; }
        //public DbSet<AppWebNeo.Models.ContatoInputModel> ContatoInputModel { get; set; }
        //public DbSet<AppWebNeo.Models.ContatoViewModel> ContatoViewModel { get; set; }

    }
}
