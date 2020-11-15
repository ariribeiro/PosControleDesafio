using PosControleDesafio.Application.DTO.DTO;
using PosControleDesafio.Application.Interfaces;
using PosControleDesafio.Domain.Core.Interfaces.Services;
using PosControleDesafio.Infra.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;


namespace PosControleDesafio.Application.Service
{
    public class ApplicationServiceUsuario : IDisposable, IApplicationServiceUsuario
    {
        private readonly IServiceUsuario _serviceUsuario;
        private readonly IMapperUsuario _mapperUsuario;

        public ApplicationServiceUsuario(IServiceUsuario ServiceUsuario, IMapperUsuario MapperUsuario)
        {
            _serviceUsuario = ServiceUsuario;
            _mapperUsuario = MapperUsuario;
        }

        public void Add(UsuarioDTO obj)
        {
            var objUsuario = _mapperUsuario.MapperToEntity(obj);
            _serviceUsuario.Add(objUsuario);
        }

        public void Dispose()
        {
            _serviceUsuario.Dispose();
        }

        public IEnumerable<UsuarioDTO> GetAll()
        {
            var objUsuarios = _serviceUsuario.GetAll();
            return _mapperUsuario.MapperListUsuarios(objUsuarios);
        }

        public UsuarioDTO GetById(int id)
        {
            var objUsuario = _serviceUsuario.GetById(id);
            return _mapperUsuario.MapperToDTO(objUsuario);
        }

        public void Remove(UsuarioDTO obj)
        {
            var objUsuario = _mapperUsuario.MapperToEntity(obj);
            _serviceUsuario.Remove(objUsuario);
        }

        public string GenerateToken(UsuarioDTO _usuarioDTO, string _secretKey)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, _usuarioDTO.username.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, _usuarioDTO.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(4), // Credencial válida por tres horas
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public void Update(UsuarioDTO obj)
        {
            var objUsuario = _mapperUsuario.MapperToEntity(obj);
            _serviceUsuario.Update(objUsuario);
        }

        public UsuarioDTO Authenticate(string _login, string _senha, string _secretKey)
        {
            
            var usuario = this._serviceUsuario.FindByFilter(w => w.username == _login && w.senha == _senha);
            if (usuario == null)
                return null;

            UsuarioDTO usuarioDTO = _mapperUsuario.MapperToDTO(usuario);
            usuarioDTO.token = this.GenerateToken(usuarioDTO, _secretKey);
            usuarioDTO.senha = "";

            return usuarioDTO;
                        
        }

    }
}
