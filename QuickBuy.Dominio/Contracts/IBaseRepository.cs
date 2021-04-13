﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
