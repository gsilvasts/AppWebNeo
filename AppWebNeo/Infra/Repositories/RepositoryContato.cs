using AppWebNeo.Infra.Data;
using AppWebNeo.Interface;
using AppWebNeo.Models;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebNeo.Infra.Repositories
{
    public class RepositoryContato : IContato
    {
        private readonly ApplicationDbContext _dbContext;

        public RepositoryContato(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(Contato Objeto)
        {
            await _dbContext.Contatos.AddAsync(Objeto);
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<Contato> List()
        {
            var contato = _dbContext.Contatos.AsQueryable();           
            return (contato);
        }
    }
}
