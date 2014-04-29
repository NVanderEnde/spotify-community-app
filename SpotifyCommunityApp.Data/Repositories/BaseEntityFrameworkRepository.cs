using SpotifyCommunityApp.Data.Context;
using SpotifyCommunityApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCommunityApp.Data.Repositories
{
    /// <summary>
    /// Provides superclassed access to the entity framework DBContext
    /// And any other functionality which should be shared between entity repositories
    /// </summary>
    abstract class BaseEntityFrameworkRepository<T> where T: BasePersistedEntity
    {
        protected AppContext _context;
        protected DbSet<T> _entities
        {
            get
            {
                return _context.Set<T>();
            }
        }
    }
}
