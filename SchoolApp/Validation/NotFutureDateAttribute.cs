
using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolApp.Validation
{
    public class NotFutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(
            object? value,
            ValidationContext validationContext)
        {
            if (value is DateTime date && date.Date > DateTime.Today)
            {
                return new ValidationResult(
                    ErrorMessage ?? "The date can't be in the future.");
            }

            return ValidationResult.Success;
        }
    }
}
