    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;


    namespace ProductsAndCategories.Models
    {
        public class Product
        {
            [Key]
            public int ProductId {get;set;}
            [Required]
            public string Name {get;set;}
            [Required]
            public string Description {get;set;}
            [Required]
            public int Price {get;set;}
            public List<Association> productsAssociated { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }