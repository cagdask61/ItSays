using ItSays.Core.Entities.Concrete;
using ItSays.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.Abstract
{
    public interface IAuthorService
    {
        List<OperationClaim> GetClaims(Author author);
        IResult Add(Author author);
        Author GetByMail(string email);
    }
}
