﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {

        void Adicionar(TEntity entity);

        void Atualizar(TEntity entity);

        void Remover(TEntity entity);
    }
}
