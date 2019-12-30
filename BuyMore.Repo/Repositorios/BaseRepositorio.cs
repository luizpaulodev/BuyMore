using System;
using System.Collections.Generic;
using System.Linq;
using BuyMore.Dom.Contratos;
using BuyMore.Repo.Contexto;

namespace BuyMore.Repo.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly AppDbContexto Context;

        public BaseRepositorio(AppDbContexto Context)
        {
            this.Context = Context;
        }

        public void Adicionar(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);  
            Context.SaveChanges();       
        }

        public void Atualizar(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);    
            Context.SaveChanges();    
        }

        public void Remover(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);    
            Context.SaveChanges();    
        }

        public TEntity ObterPorId(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return Context.Set<TEntity>().ToList();
        }      

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}