using ItSays.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Core.Utilities.Security.JWT.Abstract
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(Author author, List<OperationClaim> operationClaims);

    }
}
