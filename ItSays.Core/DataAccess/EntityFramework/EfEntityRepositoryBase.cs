using ItSays.Core.DataAccess.Abstract;
using ItSays.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace ItSays.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<AEntity, AContext> : IEntityRepository<AEntity>
        where AEntity : class, IEntity, new()
        where AContext : DbContext, new()
    {


        public void Add(AEntity entity)
        {
            using (AContext context = new AContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(AEntity entity)
        {
            using (AContext context = new AContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public AEntity Get(Expression<Func<AEntity, bool>> filter)
        {
            using (AContext context = new AContext())
            {
                return context.Set<AEntity>().SingleOrDefault(filter);
            }
        }

        public List<AEntity> GetAll(Expression<Func<AEntity, bool>> filter = null)
        {
            using (AContext context = new AContext())
            {
                return filter == null ? context.Set<AEntity>().ToList() : context.Set<AEntity>().Where(filter).ToList();
            }
        }

        public void Update(AEntity entity)
        {
            using (AContext context = new AContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

       
    }
}
