using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class WeddingUsers
        {
            [Key]
            public int WeddingUserId {get;set;}
            [Required]
            public string WedCoupleName1 {get;set;}
            [Required]
            public string WedCoupleName2 {get;set;}
            [Required]
            [DataType(DataType.Date)]
            public DateTime Date {get;set;}
            [Required]
            public string WeddingAddress {get;set;}
            public int UserId { get; set;}
            public RegisterUser RegUserData {get;set;}
            public List<RSVP> AllUsers {get;set;}
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
}