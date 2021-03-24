using FluentValidation;
using ItSays.Business.Constants;
using ItSays.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotNull();
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage(Messages.CategoryNameNotEmpty);
        }
        
    }
}
