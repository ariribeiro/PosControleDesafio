using PosControleDesafio.Application.DTO.DTO;
using System.Collections.Generic;

namespace PosControleDesafio.Application.Interfaces
{
    public interface IApplicationServiceCategoria
    {
        void Add(CategoriaDTO obj);

        CategoriaDTO GetById(int id);

        IEnumerable<CategoriaDTO> GetAll();

        void Update(CategoriaDTO obj);

        void Remove(CategoriaDTO obj);

        void Dispose();

    }
}
