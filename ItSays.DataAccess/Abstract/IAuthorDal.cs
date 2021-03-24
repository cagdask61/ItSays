using ItSays.Core.DataAccess.Abstract;
using ItSays.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.DataAccess.Abstract
{
    public interface IAuthorDal : IEntityRepository<Author>
    {

        List<OperationClaim> GetClaims(Author author);
    }
}
