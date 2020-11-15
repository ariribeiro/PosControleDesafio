using PosControleDesafio.Application.DTO.DTO;
using PosControleDesafio.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace PosControleDesafio.Presentatio.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IApplicationServiceUsuario _applicationServiceUsuario;
        IConfiguration _configuration;
        public UsuariosController(IApplicationServiceUsuario ApplicationServiceUsuario, IConfiguration configuration)
        {
            _configuration = configuration;
            _applicationServiceUsuario = ApplicationServiceUsuario;
        }


        // GET api/values
        [HttpPost("Authenticate")]
        [SwaggerOperation(Summary = "Método para autenticar o usuário")]
        [AllowAnonymous]
        public ActionResult Authenticate([FromBody] UsuarioDTO usuarioDTO)
        {
            string _secretKey = this._configuration["SecretKey"];
            UsuarioDTO user = _applicationServiceUsuario.Authenticate(usuarioDTO.username, usuarioDTO.senha, _secretKey);
            if (user == null)
                return Ok("Falha na autenticação");

            return Ok(user);
        }

        
        // POST api/values
        [HttpPost]
        [SwaggerOperation(Summary = "Cadastra usuário")]
        [AllowAnonymous]
        public ActionResult Post([FromBody] UsuarioDTO UsuarioDTO)
        {
            try
            {
                if (UsuarioDTO == null)
                    return NotFound();


                _applicationServiceUsuario.Add(UsuarioDTO);
                return Ok("O Usuario foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
    }

}

