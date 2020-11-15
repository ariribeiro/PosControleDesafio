using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PosControleDesafio.Application.DTO.DTO
{
    public class CategoriaDTO
    {
        public int? Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
    }
}
