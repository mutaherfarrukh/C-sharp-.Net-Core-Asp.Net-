using System;

namespace ModelTalk.Models
{
    public class Sundae
    {
        //number of scoops
        public int Scoops {get;set;}
        //ice creams flavor
        public string Flavor {get;set;}
        //sauce
        public string Sauce {get;set;}
        //topping
        public string Topping {get;set;}
        //has whipped cream and cherry
        public bool WhippedAndCherry {get;set;}
    }
}