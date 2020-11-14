using PosControleDesafio.Domain.Core.Interfaces.Repositorys;
using PosControleDesafio.Domain.Models;
using PosControleDesafio.Infra.Data;

namespace PosControleDesafio.Infra.Repository.Repositorys
{
    public class RepositoryCategoria : RepositoryBase<Categoria>, IRepositoryCategoria
    {

        private readonly SqlContext _context;
        public RepositoryCategoria(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

    }
}
