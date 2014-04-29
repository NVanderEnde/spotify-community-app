using SpotifyCommunityApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCommunityApp.Data.Repositories
{
    /// <summary>
    /// Defines data persistence functionality.
    /// Try to avoid exposing IQueryable if you can. I think it's better to achieve graph depth through interface methods.
    /// If neccessary, we can make more entity-specific repository interfaces and inherit from this base.
    /// </summary>
    /// <typeparam name="T">Each persisted entity has its own strongly typed repository.</typeparam>
    public interface IRepository<T> where T: BasePersistedEntity
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Read(Guid id);
        IEnumerable<T> ReadAll();
    }
}
