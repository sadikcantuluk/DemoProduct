using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş geçilemez!") ;
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün adı minimum 3 karakterli olmalıdır."); 
        }
    }
}
