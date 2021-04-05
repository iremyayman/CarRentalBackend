﻿using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(c => c.CarId).NotNull();
            RuleFor(c => c.CarImageId).NotNull().LessThanOrEqualTo(5); ;
            
        }
    }
}
