using System;
using System.ComponentModel.DataAnnotations;
using ChefsNDishes.Models;
namespace ChefsNDishes
{
    public class MinAgeAttribute : ValidationAttribute
    {
        public DateTime ObjectToDateTime(object o)
        {
            DateTime dt;
            DateTime.TryParse(o.ToString(), out dt);
            return dt;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime DoB = ObjectToDateTime(value);

            double age = (int.Parse(DateTime.Now.ToString("yyyyMMdd")) - int.Parse(DoB.ToString("yyyyMMdd"))) / 10000;

            if (age < 18)
            {
                return new ValidationResult("Chefs must be at least 18 years old.");
            }
            else { return ValidationResult.Success; }

        }

    }
}