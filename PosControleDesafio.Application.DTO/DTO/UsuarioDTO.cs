using System;
using System.Collections.Generic;
using System.Text;

namespace PosControleDesafio.Application.DTO.DTO
{
    public class UsuarioDTO
    {
        public int? Id { get; set; }
        public string username { get; set; }
        public string senha { get; set; }
        public string token { get; set; }
    }
}
