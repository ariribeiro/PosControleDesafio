using Autofac;
using PosControleDesafio.Application.Interfaces;
using PosControleDesafio.Application.Service;
using PosControleDesafio.Domain.Core.Interfaces.Repositorys;
using PosControleDesafio.Domain.Core.Interfaces.Services;
using PosControleDesafio.Domain.Service.Services;
using PosControleDesafio.Infra.CrossCutting.Adapter.Interfaces;
using PosControleDesafio.Infra.CrossCutting.Adapter.Map;
using PosControleDesafio.Infra.Repository.Repositorys;

namespace PosControleDesafio.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceCategoria>().As<IApplicationServiceCategoria>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ApplicationServiceUsuario>().As<IApplicationServiceUsuario>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceCategoria>().As<IServiceCategoria>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<ServiceUsuario>().As<IServiceUsuario>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryCategoria>().As<IRepositoryCategoria>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<RepositoryUsuario>().As<IRepositoryUsuario>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperCategoria>().As<IMapperCategoria>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            builder.RegisterType<MapperUsuario>().As<IMapperUsuario>();
            #endregion

            #endregion

        }
    }
}
