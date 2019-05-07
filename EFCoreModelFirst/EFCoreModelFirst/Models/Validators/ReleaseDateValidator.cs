using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreModelFirst.Models.Validators
{
    public class ReleaseDateValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var inputDate = (DateTime)value;
            if (inputDate <= DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Release Date cannot be future date");
            }

            //return base.IsValid(value, validationContext);
        }

    }
}
