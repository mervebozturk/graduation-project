using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PycApi.Base
{
    public class EmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                if (value is null)
                    return new ValidationResult("Invalid Email field.");

                if (Regex.IsMatch(value.ToString(), @"\s", RegexOptions.Compiled))
                    return new ValidationResult("Email is not contain any space characters.");

                return ValidationResult.Success;
            }
            catch
            {
                return new ValidationResult("Invalid Email field.");
            }
        }

    }
}
