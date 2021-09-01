using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class RSVP
        {
            [Key]
            public int RSVPId {get;set;}
            public int WeddingId  {get;set;}
            public WeddingUsers WeddingRSVP {get;set;}
            public int UserId {get;set;}
            public RegisterUser RegUser {get;set;}
        }
}