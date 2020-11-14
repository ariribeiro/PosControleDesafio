using PosControleDesafio.Application.DTO.DTO;
using PosControleDesafio.Domain.Models;
using System.Collections.Generic;

namespace PosControleDesafio.Infra.CrossCutting.Adapter.Interfaces
{
    public interface IMapperProduto
    {
        #region Mappers

        Produto MapperToEntity(ProdutoDTO clienteDTO);

        IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> clientes);

        ProdutoDTO MapperToDTO(Produto Cliente);

        #endregion
    }
}
