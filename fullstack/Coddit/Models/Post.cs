using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coddit.Models
{
    public class Post
    {
        [Key]
        public int PostId{get;set;}
        [Required]
        [MinLength(8)]
        public string Title {get;set;}
        [Required]
        public string Topic {get;set;}
        [Required]
        public string Link {get;set;}
        public int UserId {get;set;}
        public User Creator {get;set;}
        public List<Comment> CommentsMade {get;set;}
        public List<Like> Likes {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}