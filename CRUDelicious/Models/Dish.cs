using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDelicious.Models
{
    public class Dish
        {
            [Key]
            public int DishId {get;set;}
            [Required]
            public string ChefName {get; set;}
            [Required]
            public string DishName {get; set;}
            [Required]
            public string Calories {get;set;}
            [Required]
            public string Description {get; set;}
            [Required]
            public int Tastiness {get; set;}
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }