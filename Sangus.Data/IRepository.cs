using Sangus.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sangus.Data
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        SangusDbContext Ctx { get; }

        Task<List<TEntity>> GetAll();

        TEntity GetById(int id);
        TEntity Add(TEntity entidad);
        bool Remove(TEntity entidad);
        TEntity Modify(TEntity entidad);

    }
}
