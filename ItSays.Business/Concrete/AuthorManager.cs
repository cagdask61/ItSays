using ItSays.Business.Abstract;
using ItSays.Business.Constants;
using ItSays.Core.Entities.Concrete;
using ItSays.Core.Utilities.Results.Abstract;
using ItSays.Core.Utilities.Results.Concrete;
using ItSays.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }


        public IResult Add(Author author)
        {
            _authorDal.Add(author);
            return new SuccessResult();
        }

        public Author GetByMail(string email)
        {
            return _authorDal.Get(a => a.Email == email);
        }

        public List<OperationClaim> GetClaims(Author author)
        {
            return _authorDal.GetClaims(author);
        }
    }
}
