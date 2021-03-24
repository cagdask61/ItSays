using FluentValidation;
using ItSays.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.ValidationRules.FluentValidation
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(ar => ar.Title).NotEmpty();
            RuleFor(ar => ar.Writing).NotEmpty();
            //RuleFor(ar => ar.Date).NotEmpty();
            RuleFor(ar => ar.Writing).Length(5, 3000);
        }
    }
}
