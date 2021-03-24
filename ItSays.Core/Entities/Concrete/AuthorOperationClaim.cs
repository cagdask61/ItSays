using ItSays.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Core.Entities.Concrete
{
    public class AuthorOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
