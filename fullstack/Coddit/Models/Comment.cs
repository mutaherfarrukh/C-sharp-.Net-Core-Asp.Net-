using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coddit.Models
{
    public class Comment
    {
        [Key]
        public int CommentId{get;set;}
        [Required]
        [MinLength(5)]
        public string Content {get;set;}
        public int UserId {get;set;}
        public User Creator {get;set;}
        public int PostId {get;set;}
        public Post CommentingOn {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}