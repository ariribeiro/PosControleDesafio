using PosControleDesafio.Application.DTO.DTO;
using PosControleDesafio.Domain.Models;
using PosControleDesafio.Infra.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace PosControleDesafio.Infra.CrossCutting.Adapter.Map
{
    public class MapperCategoria: IMapperCategoria
    {

        #region Properties

        List<CategoriaDTO> categoriaDTOs = new List<CategoriaDTO>();

        #endregion

        #region methods

        public Categoria MapperToEntity(CategoriaDTO categoriaDTO)
        {
            Categoria categoria = new Categoria
            {

                Id = categoriaDTO.Id,
                nome = categoriaDTO.nome,
                descricao = categoriaDTO.descricao

            };

            return categoria;

        }

        public IEnumerable<CategoriaDTO> MapperListCategorias(IEnumerable<Categoria> categorias)
        {
            foreach (var item in categorias)
            {

                CategoriaDTO categoriaDTO = new CategoriaDTO
                {
                    Id = item.Id,
                    nome = item.nome,
                    descricao = item.descricao

                };

                categoriaDTOs.Add(categoriaDTO);
            }


            return categoriaDTOs;

        }

        public CategoriaDTO MapperToDTO(Categoria categoria)
        {
            CategoriaDTO categoriaDTO = new CategoriaDTO
            {
                Id = categoria.Id,
                nome = categoria.nome,
                descricao = categoria.descricao,
            };

            return categoriaDTO;

        }

        #endregion
    }
}
