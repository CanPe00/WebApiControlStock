using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiControlStock.Validations
{
    public class LineaProductoAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            string x= value.ToString().ToUpper();
            if(x == "H" || x == "S")
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Línea de producto solo acepta \"H\" y \"S\"!");
        }
    }
}
