using PosControleDesafio.Domain.Core.Interfaces.Repositorys;
using PosControleDesafio.Domain.Core.Interfaces.Services;
using PosControleDesafio.Domain.Models;

namespace PosControleDesafio.Domain.Service.Services
{
    public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
    {
        private readonly IRepositoryUsuario _repositoryUsuario;

        public ServiceUsuario(IRepositoryUsuario RepositoryUsuario)
            : base(RepositoryUsuario)
        {
            _repositoryUsuario = RepositoryUsuario;
        }

       
    }
}
