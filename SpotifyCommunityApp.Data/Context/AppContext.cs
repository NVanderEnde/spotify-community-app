using SpotifyCommunityApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCommunityApp.Data.Context
{
    class AppContext : DbContext
    {
        DbSet<Community> Communities { get; set; }        

        /// <summary>
        /// If these are new entities (and thus have not yet been assigned a PK)
        /// We will do that here by giving them a sequential GUID, or COMB
        /// </summary>
        /// <returns>Base.SaveChanges()</returns>
        public override int SaveChanges()
        {            
            foreach (DbEntityEntry pendingChange in this.ChangeTracker.Entries())
            {
                var entity = pendingChange.Entity as BasePersistedEntity;
                if (entity == null)
                {
                    //If we're trying to persist something that isn't a subclass of BasePersistedEntity...
                    //I don't expect this to happen, but this is better than tossing out an unhelpful null reference
                    throw new InvalidOperationException("Cannot persist something that is not a subclass of BasePersistedEntity.");
                }

                if (entity.Id == null || entity.Id == Guid.Empty)
                {
                    entity.Id = COMBinator.GenerateComb();
                }
            }
            return base.SaveChanges();
        }
    }
}
