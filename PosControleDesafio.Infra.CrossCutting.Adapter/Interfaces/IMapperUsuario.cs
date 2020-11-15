using PosControleDesafio.Application.DTO.DTO;
using PosControleDesafio.Domain.Models;
using System.Collections.Generic;

namespace PosControleDesafio.Infra.CrossCutting.Adapter.Interfaces
{
    public interface IMapperUsuario
    {
        #region Mappers

        Usuario MapperToEntity(UsuarioDTO usuarioDTO);

        IEnumerable<UsuarioDTO> MapperListUsuarios(IEnumerable<Usuario> usuarios);

        UsuarioDTO MapperToDTO(Usuario usuario);

        #endregion

    }
}
