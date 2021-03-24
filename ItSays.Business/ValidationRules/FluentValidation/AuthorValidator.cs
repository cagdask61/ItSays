using FluentValidation;
using ItSays.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.ValidationRules.FluentValidation
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(a => a.Email).NotNull();
            RuleFor(a => a.FirstName).NotNull();
            RuleFor(a => a.LastName).NotNull();
            RuleFor(a => a.PasswordHash).NotNull();
            RuleFor(a => a.PasswordSalt).NotNull();
        }
    }
}
