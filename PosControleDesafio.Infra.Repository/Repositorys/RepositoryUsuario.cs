using PosControleDesafio.Domain.Core.Interfaces.Repositorys;
using PosControleDesafio.Domain.Models;
using PosControleDesafio.Infra.Data;

namespace PosControleDesafio.Infra.Repository.Repositorys
{
    public class RepositoryUsuario : RepositoryBase<Usuario>, IRepositoryUsuario
    {

        private readonly SqlContext _context;
        public RepositoryUsuario(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

        
    }
}
