using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CName).NotEmpty().WithMessage("Category cannot be blank");
            RuleFor(x => x.CDescription).NotEmpty().WithMessage("Description cannot be blank");
            RuleFor(x => x.CName).MaximumLength(20).MinimumLength(3).WithMessage("Please enter a valid category");
          
        }
    }
}
