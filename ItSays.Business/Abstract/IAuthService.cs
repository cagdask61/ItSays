using ItSays.Core.Entities.Concrete;
using ItSays.Core.Utilities.Results.Abstract;
using ItSays.Core.Utilities.Security.JWT;
using ItSays.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Author> Register(AuthorForRegisterDto authorForRegisterDto, string password);
        IDataResult<Author> Login(AuthorForLoginDto authorForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(Author author);
    }
}
