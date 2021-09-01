using System;
using System.ComponentModel.DataAnnotations;

namespace CharactersPowers.Models
{
    public class CharacterHasPower
    {
        [Key]
        public int CharacterHasPowerId {get;set;}
        public int CharacterId {get;set;}
        public Character Character {get;set;}
        public int PowerId {get;set;}
        public Power Power {get;set;}
    }

}