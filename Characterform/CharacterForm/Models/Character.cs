using System;
using System.ComponentModel.DataAnnotations;

namespace CharacterForm.Models
{
    public class Character
    {
        [Required(ErrorMessage ="You Absolutely need to have First name!")]
        [Display(Name ="First Name")]
        [MinLength(2, ErrorMessage =" You Need atleast 2 characters in the First Name!")]
        public string FirstName {get; set;}

        [Required]
        [Display(Name ="Last Name")]
        public string LastName {get; set;}

        [Required]
        [NoTimeTravel]
        
        public DateTime Birthday {get; set;}

        [Required]
        public string HomeTown {get; set;}

        [Required]
        public string ImageURL {get; set;}

        [Required]
        [Display(Name ="Favorite Hobby")]
        public string FaveHobby {get; set;}
    }

// CUSTOM VALIDATION MADE//////
    public class NoTimeTravel : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime)
            {
                //check if vallide
                DateTime checkMe;
                checkMe = (DateTime)value;

                if(checkMe > DateTime.Now)
                {
                    return new ValidationResult("No time travel is Allowed");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("not a date time");
            }
        }
    }
}