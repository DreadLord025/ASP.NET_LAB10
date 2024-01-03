using System.ComponentModel.DataAnnotations;
using LAB10.Models;

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime date)
        {
            if (date > DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Дата має бути в майбутньому.");
            }
        }
        else
        {
            return new ValidationResult("Некоректна дата.");
        }
    }
}

public class NoWeekendsAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime date)
        {
            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Консультація не може бути в вихідні.");
            }
        }
        else
        {
            return new ValidationResult("Некоректна дата.");
        }
    }
}

public class NoBasicOnMondaysAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var form = (RegistrationFormModel)validationContext.ObjectInstance;

        if (form.Product == "Основи" && form.DesiredDate.DayOfWeek == DayOfWeek.Monday)
        {
            return new ValidationResult("Консультація щодо продукту «Основи» не може проходити по понеділках.");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}
