    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;


    namespace ProductsAndCategories.Models
    {
        public class Association
        {
            public int AssociationId {get;set;}
            public int ProductId {get;set;}
            public int CategoryId {get;set;}
            public Product products {get;set;}
            public Category categories {get;set;}
        }
    }