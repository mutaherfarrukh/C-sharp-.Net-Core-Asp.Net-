using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharactersPowers.Models
{
    public class Character
    {
        [Key]
        public int CharacterId {get;set;}
        //name, hasCape, weakness, isEvil, nemesis, real name, motto
        public string Name {get;set;}
        [Required]
        public bool HasCape {get;set;}
        [Required]
        public string Weakness {get;set;}
        [Required]
        public bool IsEvil {get;set;}
        public string Nemesis {get;set;}
        [Required]
        public string RealName {get;set;}
        public string CatchPhrase {get;set;}
        public List<CharacterHasPower> CharacterPowers {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}