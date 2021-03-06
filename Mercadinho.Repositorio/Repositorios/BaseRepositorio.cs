﻿using Mercadinho.Dominio.Contratos;
using Mercadinho.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class

    {
        protected readonly MercadinhoContexto MercadinhoContexto;
        public BaseRepositorio(MercadinhoContexto mercadinhoContexto)
        {
            MercadinhoContexto = mercadinhoContexto;
        }

        public void Adicionar(TEntity entity)
        {
            MercadinhoContexto.Set<TEntity>().Add(entity);
            MercadinhoContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            MercadinhoContexto.Set<TEntity>().Update(entity);
            MercadinhoContexto.SaveChanges();
        }

        public void Dispose()
        {
            MercadinhoContexto.Dispose();
        }

       
        public void Remover(TEntity entity)
        {
            MercadinhoContexto.Remove(entity);
            MercadinhoContexto.SaveChanges();
        }
    }
}
