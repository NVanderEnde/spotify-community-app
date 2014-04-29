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
    public class CommunityRepository : BaseEntityFrameworkRepository<Community>, IRepository<Community>
    {      
        /// <summary>
        /// Instantiates a new DBContext
        /// </summary>
        public CommunityRepository()
        {
            _context = new AppContext();
        }

        public void Insert(Community entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Community entity)
        {
            _entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        /// <summary>
        /// TODO: We probably want the action of deleting a Community (which is the parent object in the graph) to delete all of its children, too.
        /// Otherwise we'll end up with orphans running around in our database.
        /// I'm leaving this note here as a reminder to clean up the object graph as we add navigation properties to the Community class.
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(Community entity)
        {
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public Community Read(Guid id)
        {
            return _entities.FirstOrDefault(community => community.Id == id);
        }

        public IEnumerable<Community> ReadAll()
        {
            return _entities;
        }
    }
}
