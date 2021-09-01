using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coddit.Models
{
    public class Like   
    {
        [Key]
        public int LikeId {get;set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int PostId {get;set;}
        public Post Post {get;set;}
    }
}