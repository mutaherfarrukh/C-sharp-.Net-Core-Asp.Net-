    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;


    namespace Chefs_N_Dishes.Models
    {
        public class Chef
        {
            [Key]
            public int ChefId {get;set;}
            [Required]

            public string FirstName {get;set;}
            [Required]

            public string LastName {get;set;}
            [Required]
            [DataType(DataType.Date)]
            public DateTime DateOfBirth {get;set;}
            public List<Dish> CreatedDishes {get;set;}

            public DateTime CreatedAt {get;set;} = DateTime.Now;

            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }