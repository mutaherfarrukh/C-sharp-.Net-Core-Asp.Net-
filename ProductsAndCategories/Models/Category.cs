    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;


    namespace ProductsAndCategories.Models
    {
        public class Category
        {
            [Key]
            public int CategoryId {get;set;}
            [Required]
            public string CategoryName {get;set;}
            public List<Association> categoriesAssociated { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }