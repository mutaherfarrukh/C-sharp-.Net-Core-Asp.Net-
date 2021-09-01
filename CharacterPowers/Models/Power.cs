using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharactersPowers.Models
{
    public class Power
    {
        [Key]
        public int PowerId {get;set;}
        //name, description, power level(1-10), type
        [Required]
        public string PowerName {get;set;}
        [Required]
        public string Description {get;set;}
        [Required]
        [Range(0,10)]
        public int PowerLevel {get;set;}
        [Required]
        public string Type {get;set;}
        public List<CharacterHasPower> CharacterPowers {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}