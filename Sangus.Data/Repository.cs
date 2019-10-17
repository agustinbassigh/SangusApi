using Microsoft.EntityFrameworkCore;
using Sangus.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sangus.Data
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        public SangusDbContext Ctx { get; }

        public Repository(SangusDbContext ctx)
        {
            Ctx = ctx;

        }

        public Task<List<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }


        public TEntity Add(TEntity entidad)
        {
            GetDbSet().Add(entidad);
            return entidad;
        }

        public TEntity Modify(TEntity entidad)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TEntity entidad)
        {
            throw new NotImplementedException();
        }

        private DbSet<TEntity> GetDbSet()
        {
            return Ctx.Set<TEntity>();

        }

    }
}
