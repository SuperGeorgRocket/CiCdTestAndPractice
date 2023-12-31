﻿using RepoLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IEmployeeBL<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        bool Add(TEntity entity);
        bool Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }
}
