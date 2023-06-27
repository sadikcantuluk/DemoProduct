﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim boş geçilemez!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Minimum 3 karakter");
        }
    }
}
