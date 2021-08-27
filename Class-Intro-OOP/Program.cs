using System;

namespace Class_Intro_OOP
{
    public class Robot  //(1) make a CLASS/////////////CLASSES have VARIABLES, METHODS, and CONSTRUCTORS//////////////////////////
    {
        //(2)
        public string Name;
        public string Color;
        private int oilLevel;/////PRIVATE can be managed by its own class but not asseced publically//////
        public Robot(string name){////////<<<<this is CONSTRUCTOR and it will be the same name as CLASS in C#////
            Name = name;//////////////leftside "Name" is parameter and right side "name" (lowercase) is the feature of the class////
            Color = "silver";
            oilLevel = 90;
        }

        public Robot(string name, string color)
        {
            Console.WriteLine("More detailed constructor");
            Name = "Bender";
            Color = color;
            oilLevel = 90;
        }

        public Robot(){
            Console.WriteLine("Less detailed constructor");
            Name = "Bender";
            Color = "Silver";
            oilLevel = 90;
        }

        public void ServeDinner()
        {
            oilLevel -= 30;
            Console.WriteLine("Here I served you a platter of nuts and bolts");
        }

        public void KillAllHumans()
        {
            oilLevel -= 50;
            Console.WriteLine("Here I served you a platter of pain");
        }

        public void PrintStatus(){////<<<<we did because our "OilLevel" was private so in order to get it we have to create a function/// This is ABSTRACTION////
            if(oilLevel > 60)
            {
                Console.WriteLine("Internal Status is all good");
            }
            else if(oilLevel > 30){
                Console.WriteLine("Maintainance Needed");
            }
            else{
                Console.WriteLine("beep boop bop, pls help light is fading");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Robot sbeve = new Robot("Sbeve");/////<<<<here we create Instance of the class to call the function//// in parenthesis we will put attributes for example here we only have name which we gave as "Sbeve"////



            sbeve.ServeDinner();
            sbeve.PrintStatus();
            Robot Bender = new Robot();
        }
    }
}
