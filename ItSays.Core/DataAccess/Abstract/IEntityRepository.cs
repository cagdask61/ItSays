using ItSays.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ItSays.Core.DataAccess.Abstract
{
    public interface IEntityRepository<A> where A:class ,IEntity, new()
    {
        void Add(A entity);
        void Delete(A entity);
        void Update(A entity);

        List<A> GetAll(Expression<Func<A, bool>> filter=null);

        A Get(Expression<Func<A,bool>> filter);

        
    }
}
