using System;
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //??what is in value??

            DateTime CurrentTime = DateTime.UtcNow;
            DateTime inputDate = Convert.ToDateTime(value);

            // logic for datetime =>  value.Date > CurrentTime
            if (inputDate > CurrentTime)
            {
                Console.WriteLine($"\n*************\n\ninputDate: {inputDate}");
                return new ValidationResult(" is invalid.");
            }
            else { return ValidationResult.Success; }

        }

    }
}