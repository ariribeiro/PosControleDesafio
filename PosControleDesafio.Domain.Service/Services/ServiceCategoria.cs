using PosControleDesafio.Domain.Core.Interfaces.Repositorys;
using PosControleDesafio.Domain.Core.Interfaces.Services;
using PosControleDesafio.Domain.Models;

namespace PosControleDesafio.Domain.Service.Services
{
    public class ServiceCategoria: ServiceBase<Categoria>, IServiceCategoria
    {
        private readonly IRepositoryCategoria _repositoryCategoria;

        public ServiceCategoria(IRepositoryCategoria RepositoryCategoria)
            : base(RepositoryCategoria)
        {
            _repositoryCategoria = RepositoryCategoria;
        }
    }
}
