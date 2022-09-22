using FluentValidation;
using PycApi.Data;

namespace PycApi.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Please enter your email address."); // Email alanı boş bırakılırsa uyarı verecek.
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please enter a valid email address."); // Geçerli bir mail adresi girilmediyse bu şekilde uyarı verecek.

            RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Please enter your password"); // Password alanı boş bırakılamaz,hata mesajı dönecek.
            RuleFor(x => x.Password).MinimumLength(8).MaximumLength(20).WithMessage("Your password must be 8-20 characters.");
        }

    }
}
