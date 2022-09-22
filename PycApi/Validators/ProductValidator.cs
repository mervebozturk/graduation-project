using FluentValidation;
using PycApi.Data;

namespace PycApi.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotNull().WithMessage("Please enter product name"); // Product Name alanı boş bırakılırsa uyarı verecek.
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("Product name must be 100 characters");


            RuleFor(x => x.ProductDescription).NotNull().NotEmpty().WithMessage("Please enter product description"); // Product description boş bırakılamaz,hata mesajı dönecek.
            RuleFor(x => x.ProductDescription).MaximumLength(500).WithMessage("Product description must be 500 characters.");
        }

    }
}
