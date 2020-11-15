using PosControleDesafio.Application.DTO.DTO;
using PosControleDesafio.Domain.Models;
using PosControleDesafio.Infra.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;

namespace PosControleDesafio.Infra.CrossCutting.Adapter.Map
{
    public class MapperUsuario : IMapperUsuario
    {

        #region Properties

        List<UsuarioDTO> usuarioDTOs = new List<UsuarioDTO>();

        #endregion

        #region methods

        public Usuario MapperToEntity(UsuarioDTO usuarioDTO)
        {
            if (usuarioDTO == null)
                throw new Exception("Usuário não encontrado");

            Usuario usuario = new Usuario
            {

                Id = usuarioDTO.Id,
                username = usuarioDTO.username,
                senha = usuarioDTO.senha

            };

            return usuario;

        }

        public IEnumerable<UsuarioDTO> MapperListUsuarios(IEnumerable<Usuario> usuarios)
        {
            foreach (var item in usuarios)
            {

                UsuarioDTO usuarioDTO = new UsuarioDTO
                {
                    Id = item.Id,
                    username = item.username,
                    senha = item.senha

                };

                usuarioDTOs.Add(usuarioDTO);
            }


            return usuarioDTOs;

        }

        public UsuarioDTO MapperToDTO(Usuario usuario)
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO
            {
                Id = usuario.Id,
                username= usuario.username,
                senha = usuario.senha
            };

            return usuarioDTO;

        }

        #endregion
    }
}

