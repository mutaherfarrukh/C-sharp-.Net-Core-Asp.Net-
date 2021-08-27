using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Create an empty List of type object
            List<object> newList = new List<object>();

            //Add the following values to the list: 7, 28, -1, true, "chair"
            newList.Add(7);
            newList.Add(28);
            newList.Add(-1);
            newList.Add(true);
            newList.Add("chair");

            //Loop through the list and print all values [(Hint: Type Inference might help here!)~~VAR]
            foreach(var start in newList  )
            {
                Console.WriteLine(start);
            }

            //Add all values that are Int type together and output the sum
            int sum = 0;
            foreach (var start in newList)
            {
                if (start is int)
                {
                    sum += (int)start;
                }
            }
            Console.WriteLine($"The total sum of int is {sum}");
        }
        
    }
}
