using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coddit.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        public string SpiritAnimal {get;set;}
        [Required]
        [MinLength(5)]
        public string UserName {get;set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage ="must have 8 characters for the password!")]
        public string Password {get;set;}
        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm {get;set;}
        public List<Post> CreatedPosts {get;set;}
        public List<Comment> CommentsCreated {get;set;}
        public List<Like> LikesGiven {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}