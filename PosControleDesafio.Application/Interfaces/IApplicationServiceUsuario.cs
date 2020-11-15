using PosControleDesafio.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PosControleDesafio.Application.Interfaces
{
    public interface IApplicationServiceUsuario
    {
        void Add(UsuarioDTO obj);

        UsuarioDTO GetById(int id);

        IEnumerable<UsuarioDTO> GetAll();

        void Update(UsuarioDTO obj);

        void Remove(UsuarioDTO obj);

        string GenerateToken(UsuarioDTO _usuarioDTO, string _secretKey);

        UsuarioDTO Authenticate(string _login, string _senha, string _secretKey);

        void Dispose();

    }
}
