using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketBookingSystem.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AirticketBookingDatabaseEntities context;
        private readonly DbSet<T> entities;

        public Repository(AirticketBookingDatabaseEntities context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public T GetById(object id)
        {
            return entities.Find(id);
        }

    }
}
