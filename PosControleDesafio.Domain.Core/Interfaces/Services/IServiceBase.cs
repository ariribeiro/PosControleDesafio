using System;
using System.Collections.Generic;
using System.Text;

namespace PosControleDesafio.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);
        
        void Dispose();

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetByFilter(Func<TEntity, bool> predicate);

        TEntity FindByFilter(Func<TEntity, bool> predicate);

        TEntity GetById(int id);
    }
}
