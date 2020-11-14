using PosControleDesafio.Application.DTO.DTO;
using PosControleDesafio.Domain.Models;
using System.Collections.Generic;

namespace PosControleDesafio.Infra.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCategoria
    {
        #region Mappers

        Categoria MapperToEntity(CategoriaDTO categoriaDTO);

        IEnumerable<CategoriaDTO> MapperListCategorias(IEnumerable<Categoria> categorias);

        CategoriaDTO MapperToDTO(Categoria categoria);

        #endregion

    }
}
