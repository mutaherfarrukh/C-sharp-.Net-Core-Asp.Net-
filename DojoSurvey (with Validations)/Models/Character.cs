using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Dojo
    {
        [Required]
        [MinLength(2, ErrorMessage =" You Need atleast 2 characters in the Name!")]
        public string Name {get; set;}

        [Required]

        public string DojoLocation {get; set;}

        [Required]

        public string FavoriteLanguage {get; set;}
        public string Comment {get; set;}
    }
}