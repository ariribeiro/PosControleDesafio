using PosControleDesafio.Application.DTO.DTO;
using PosControleDesafio.Application.Interfaces;
using PosControleDesafio.Domain.Core.Interfaces.Services;
using PosControleDesafio.Infra.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;

namespace PosControleDesafio.Application.Service
{
    public class ApplicationServiceCategoria: IDisposable, IApplicationServiceCategoria
    {
        private readonly IServiceCategoria _serviceCategoria;
        private readonly IMapperCategoria _mapperCategoria;

        public ApplicationServiceCategoria(IServiceCategoria ServiceCategoria, IMapperCategoria MapperCategoria)
        {
            _serviceCategoria = ServiceCategoria;
            _mapperCategoria = MapperCategoria;
        }

        public void Add(CategoriaDTO obj)
        {
            var objCategoria = _mapperCategoria.MapperToEntity(obj);
            _serviceCategoria.Add(objCategoria);
        }

        public void Dispose()
        {
            _serviceCategoria.Dispose();
        }

        public IEnumerable<CategoriaDTO> GetAll()
        {
            var objCategorias = _serviceCategoria.GetAll();
            return _mapperCategoria.MapperListCategorias(objCategorias);
        }

        public CategoriaDTO GetById(int id)
        {
            var objCategoria = _serviceCategoria.GetById(id);
            return _mapperCategoria.MapperToDTO(objCategoria);
        }

        public void Remove(CategoriaDTO obj)
        {
            var objCategoria = _mapperCategoria.MapperToEntity(obj);
            _serviceCategoria.Remove(objCategoria);
        }

        public void Update(CategoriaDTO obj)
        {
            var objCategoria = _mapperCategoria.MapperToEntity(obj);
            _serviceCategoria.Update(objCategoria);
        }

    }
}
