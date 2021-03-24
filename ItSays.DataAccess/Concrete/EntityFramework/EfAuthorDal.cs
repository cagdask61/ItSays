using ItSays.Core.DataAccess.EntityFramework;
using ItSays.Core.Entities.Concrete;
using ItSays.DataAccess.Abstract;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ItSays.DataAccess.Concrete.EntityFramework
{
    public class EfAuthorDal : EfEntityRepositoryBase<Author, ItSaysContext>, IAuthorDal
    {
        public List<OperationClaim> GetClaims(Author author)
        {
            using (var context = new ItSaysContext())
            {
                var join = from operationClaim in context.OperationClaims
                           join authorOperationClaim in context.AuthorOperationClaims on operationClaim.Id equals authorOperationClaim.OperationClaimId
                           where authorOperationClaim.AuthorId == author.Id
                           select new OperationClaim
                           {
                               Id = operationClaim.Id,
                               Name = operationClaim.Name
                           };
                return join.ToList();
            }
        }
    }
}
