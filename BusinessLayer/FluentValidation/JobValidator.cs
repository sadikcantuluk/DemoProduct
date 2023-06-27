using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class JobValidator : AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Bu alan noş geçilemez.");
            RuleFor(x=>x.Name).MinimumLength(3).WithMessage("Minimum karakter sayısı 3 olmalı.");
        }
    }
}
