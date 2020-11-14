using System;
using System.Collections.Generic;
using System.Text;

namespace PosControleDesafio.Domain.Models
{
    public class Produto : Base
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public Categoria categoria { get; set; }
    }
}
