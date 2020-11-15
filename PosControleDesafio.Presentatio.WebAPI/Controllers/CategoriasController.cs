using PosControleDesafio.Application.DTO.DTO;
using PosControleDesafio.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization;

namespace PosControleDesafio.Presentation.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoriasController : ControllerBase
    {
        private readonly IApplicationServiceCategoria _applicationServiceCategoria;

        public CategoriasController(IApplicationServiceCategoria ApplicationServiceCategoria)
        {
            _applicationServiceCategoria = ApplicationServiceCategoria;
        }
        // GET api/values
        [HttpGet]
        [SwaggerOperation(Summary = "Retorna lista de Categorias")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCategoria.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Retorna produto por ID")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCategoria.GetById(id));
        }

        // POST api/values
        [HttpPost]
        [SwaggerOperation(Summary = "Insere produto")]
        public ActionResult Post([FromBody] CategoriaDTO categoriaDTO)
        {
            try
            {
                if (categoriaDTO == null)
                    return NotFound();


                _applicationServiceCategoria.Add(categoriaDTO);
                return Ok("Categoria foi cadastrada com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        [SwaggerOperation(Summary = "Atualiza categoria")]
        public ActionResult Put([FromBody] CategoriaDTO categoriaDTO)
        {

            try
            {
                if (categoriaDTO == null)
                    return NotFound();

                _applicationServiceCategoria.Update(categoriaDTO);
                return Ok("Categoria foi atualizada com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        [SwaggerOperation(Summary = "Exclui Categoria")]
        public ActionResult Delete([FromBody] CategoriaDTO categoriaDTO)
        {
            try
            {
                if (categoriaDTO == null)
                    return NotFound();

                _applicationServiceCategoria.Remove(categoriaDTO);
                return Ok("Categoria foi removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
