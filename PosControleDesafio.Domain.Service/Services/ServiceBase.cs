using PosControleDesafio.Domain.Core.Interfaces.Repositorys;
using PosControleDesafio.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace PosControleDesafio.Domain.Service.Services
{
    public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> Repository)
        {
            _repository = Repository;
        }
        public virtual void Add(TEntity obj)
        {
            _repository.Add(obj);
        }
        public virtual TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
        public virtual IEnumerable<TEntity> GetByFilter(Func<TEntity, bool> predicate)
        {
            return _repository.GetByFilter(predicate);
        }
        public virtual void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
        public virtual void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public virtual void Dispose()
        {
            _repository.Dispose();
        }

        public virtual TEntity FindByFilter(Func<TEntity, bool> predicate)
        {
            return this._repository.FindByFilter(predicate);
        }
    }
}
