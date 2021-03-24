using ItSays.Business.Abstract;
using ItSays.Business.Constants;
using ItSays.Core.Entities.Concrete;
using ItSays.Core.Utilities.Results.Abstract;
using ItSays.Core.Utilities.Results.Concrete;
using ItSays.Core.Utilities.Security.Hashing;
using ItSays.Core.Utilities.Security.JWT;
using ItSays.Core.Utilities.Security.JWT.Abstract;
using ItSays.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IAuthorService _authorService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IAuthorService authorService, ITokenHelper tokenHelper)
        {
            _authorService = authorService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<AccessToken> CreateAccessToken(Author author)
        {
            var claims = _authorService.GetClaims(author);
            var accessToken = _tokenHelper.CreateToken(author, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.Token);
        }

        public IDataResult<Author> Login(AuthorForLoginDto authorForLoginDto)
        {
            var authorToCheck = _authorService.GetByMail(authorForLoginDto.Email);

            if (authorToCheck == null)
            {
                return new ErrorDataResult<Author>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(authorForLoginDto.Password, authorToCheck.PasswordHash, authorToCheck.PasswordSalt))
            {
                return new ErrorDataResult<Author>(Messages.PasswordError);
            }

            return new SuccessDataResult<Author>(authorToCheck, Messages.SuccessFullogin);
        }

        public IDataResult<Author> Register(AuthorForRegisterDto authorForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var author = new Author
            {
                Email = authorForRegisterDto.Email,
                FirstName = authorForRegisterDto.FirstName,
                LastName = authorForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };

            _authorService.Add(author);
            return new SuccessDataResult<Author>(author, Messages.AuthorRegistered);

        }

        public IResult UserExists(string email)
        {
            if (_authorService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.AuthorAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
