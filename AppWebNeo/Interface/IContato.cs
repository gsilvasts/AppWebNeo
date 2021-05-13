using AppWebNeo.Models;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebNeo.Interface
{
    public interface IContato
    {
        Task Add(Contato Objeto);
        IQueryable<Contato> List();
    }
}
