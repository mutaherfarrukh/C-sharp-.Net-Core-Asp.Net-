    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
       using System.Collections.Generic;


    namespace Chefs_N_Dishes.Models
    {
        public class Dish
        {
            [Key]
            public int DishId {get;set;}
            [Required]
            public string Name {get; set;}
            [Required]
            public string Calories {get;set;}
            [Required]
            public string Description {get; set;}
            [Required]

            public int Tastiness {get; set;}
            [Required]

            public int ChefId { get; set;}
            public Chef Creator {get;set;}

            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
}