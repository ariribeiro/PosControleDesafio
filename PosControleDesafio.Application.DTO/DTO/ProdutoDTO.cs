using System;
using System.Collections.Generic;
using System.Text;

namespace PosControleDesafio.Application.DTO.DTO
{
    public class ProdutoDTO
    {
        public int? Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public int categoriaId { get; set; }
    }
}
