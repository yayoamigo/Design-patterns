using System.ComponentModel.DataAnnotations;

namespace Model.CustomValidation
{
    public class YearValidationAttribute : ValidationAttribute
    {
        public int MinYear { get; set; } = 2000;
        public string DefatultErrorMessage { get; set; } = "Invalid Date cant be more than {0}";

        public YearValidationAttribute()
        {

        }

        public YearValidationAttribute(int minyear)
        {
            MinYear = minyear;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                try
                {
                    DateTime date = Convert.ToDateTime(value);
                    if (date.Year >= MinYear)
                    {
                        return new ValidationResult(string.Format(ErrorMessage ?? DefatultErrorMessage, MinYear));
                    }
                }
                catch
                {
                    return new ValidationResult("Invalid Date");
                }


            }

            return ValidationResult.Success;
        }
        
    }
}
