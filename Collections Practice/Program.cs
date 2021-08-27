using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {

        //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!) ADDED SAUCE AND TOPPINGS TOO!!
        //SEE LINE 52 FOR MORE INFO//////
        public static Dictionary<string, string> randomSandae(){
        Dictionary<string, string> sundae = new Dictionary<string, string>();

        Random rand = new Random();

        string[] flavors = {"vanilla", "chocolate", "pumpkin", "banana", "garlic", "rocky road", "actual road rocks", "go cheese and mint"};
        string[] sauce = {"hot fudge", "hot sauce", "strawberry syrup", "ranch", "nutella" };
        string[] toppings = {"pecans", "wafer rolls", "mini m&ms", "Reeses cups", "Biscuits"};

        sundae.Add("iceCream", flavors[rand.Next(flavors.Length)]);
        sundae.Add("sauce", sauce[rand.Next(sauce.Length)]);
        sundae.Add("topping", toppings[rand.Next(toppings.Length)]);

        return sundae;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // //Three Basic Arrays//

            // //Create an array to hold integer values 0 through 9
            // int[] array = {0,1,2,3,4,5,6,7,8,9};

            // //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            // string[] names = {"Tim", "Martin", "Nikki", "Sara"};

            //Create an array of length 10 that alternates between true and false values, starting with true
            bool[] booleanArr = new bool[10];
            for (int i = 0; i < booleanArr.Length; i++){
                if (i % 2 == 0)
                {
                    booleanArr[i] = true;
                }
                else
                {
                    booleanArr[i] = false;
                }
            }
        
            //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            Dictionary<string, string> sundae = randomSandae();

            foreach(KeyValuePair<string, string> feature in sundae)
            //you can also use 'var' instead of 'KeyValuePair<string, string>' but not recommended.
            {
                Console.WriteLine($"The {feature.Key} in the sundae is {feature.Value}");
            }
        }
    }
}