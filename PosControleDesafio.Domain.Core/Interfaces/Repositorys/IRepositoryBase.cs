using System;
using System.Collections.Generic;


namespace PosControleDesafio.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetByFilter(Func<TEntity, bool> predicate);
        
        TEntity FindByFilter(Func<TEntity, bool> predicate);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
