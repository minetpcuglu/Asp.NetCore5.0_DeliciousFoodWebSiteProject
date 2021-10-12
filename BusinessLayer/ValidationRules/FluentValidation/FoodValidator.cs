using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class FoodValidator:AbstractValidator<Food>
    {
        public FoodValidator()
        {
            RuleFor(x => x.FName).NotEmpty().WithMessage("Category cannot be blank");
            RuleFor(x => x.FDescription).NotEmpty().WithMessage("Description cannot be blank");
            RuleFor(x => x.FImageUrl).NotEmpty().WithMessage("Image Url cannot be blank");
            RuleFor(x => x.FPrice).NotEmpty().WithMessage("Price cannot be blank");
            RuleFor(x => x.FStock).NotEmpty().WithMessage("Stock cannot be blank");
            RuleFor(x => x.FName).MaximumLength(20).MinimumLength(3).WithMessage("Please enter a valid Food");
           
        }
    }
}
