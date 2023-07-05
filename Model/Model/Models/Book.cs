using System.ComponentModel.DataAnnotations;
using Model.CustomValidation;



namespace Model.Models
{
    public class Book : IValidatableObject
    {
        [Required(ErrorMessage ="{0} this must be present")]
        public int? bookid { get; set; }
        [StringLength(100, MinimumLength = 10, ErrorMessage = "{0} most be between{2} and {1}")]
        [Display(Name = "Book Name")]
        public string? bookName { get; set; }
        [Required(ErrorMessage = " also num must be present")]
        public int? bookNumber { get; set; }
        [Required(ErrorMessage = " this must be present")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? email { get; set; }

        [YearValidation(MinYear = 2008)]
        public DateTime? Date { get; set; }

        public DateTime? FromDate { get; set; }

        [DateValidation("FromDate", ErrorMessage = "fromdate should be older than to date")]
        public DateTime? ToDate { get; set; }
        public override string ToString()
        {
            return $"your book id ";
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(bookid.HasValue == false && Date.HasValue == false) {
             yield return new ValidationResult("bookid or date must be present", new[] { nameof(Date) });
            }
        }
    }
}
