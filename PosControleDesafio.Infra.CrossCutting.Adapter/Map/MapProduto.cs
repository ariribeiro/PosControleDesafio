
using PosControleDesafio.Application.DTO.DTO;
using PosControleDesafio.Domain.Models;
using PosControleDesafio.Infra.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace PosControleDesafio.Infra.CrossCutting.Adapter.Map
{
    public class MapperProduto : IMapperProduto
    {

        #region Properties

        List<ProdutoDTO> produtoDTOs = new List<ProdutoDTO>();

        #endregion

        #region methods

        public Produto MapperToEntity(ProdutoDTO produtoDTO)
        {
            Produto produto = new Produto
            {

                Id = produtoDTO.Id,
                nome = produtoDTO.nome,
                descricao = produtoDTO.descricao,
                valor = produtoDTO.valor

            };

            return produto;

        }

        public IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> produtos)
        {
            foreach (var item in produtos)
            {

                ProdutoDTO produtoDTO = new ProdutoDTO
                {
                    Id = item.Id,
                    nome = item.nome,
                    descricao = item.descricao,
                    valor = item.valor

                };

                produtoDTOs.Add(produtoDTO);
            }


            return produtoDTOs;

        }

        public ProdutoDTO MapperToDTO(Produto produto)
        {
            ProdutoDTO produtoDTO = new ProdutoDTO
            {
                Id = produto.Id,
                nome = produto.nome,
                descricao = produto.descricao,
                valor = produto.valor
            };

            return produtoDTO;

        }

        #endregion
    }
}
