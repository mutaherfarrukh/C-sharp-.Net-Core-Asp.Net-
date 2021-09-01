using System;
using System.ComponentModel.DataAnnotations;

namespace Coddit.Models
{
    public class LoginUser
    {
        [Required]
        public string LoginUserName {get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword {get;set;}
    }

}