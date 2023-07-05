using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Model.CustomValidation
{
    public class DateValidationAttribute : ValidationAttribute
    {
        public string CompareToPropertyName { get; set; }

        public DateValidationAttribute(string comparetoPropertyName)
        {
            CompareToPropertyName = comparetoPropertyName;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
          if (value != null)
            {
                DateTime Todate = Convert.ToDateTime(value);

                
                PropertyInfo? CompareToPropery = validationContext.ObjectType.GetProperty(CompareToPropertyName);

                if (CompareToPropery != null)
                {
                    DateTime FromDate = Convert.ToDateTime(CompareToPropery.GetValue(validationContext.ObjectInstance));


                    if (FromDate > Todate)
                    {
                        return new ValidationResult(ErrorMessage , new string[] { CompareToPropertyName, validationContext.MemberName });
                    }

                    return ValidationResult.Success;
                }
                return null;

                
            }

            return null;
        }
    }
}
