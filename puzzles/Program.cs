using System;


namespace puzzles
{
    class Program
    {
        ////RANDOM ARRAY////
        //Create a function called RandomArray() that returns an integer array
        //Place 10 random integer values between 5-25 into the array
        public static int[] RandomArray()
        {
            int[] givearray = new int[10];

            Random randidx = new Random();
            for(int i=0; i <10; i++)
            {
                givearray[i] = randidx.Next(5,25);
            }

            //Print the min and max values of the array
            //Print the sum of all the values
            int min= 0;
            int max = 0;
            int sum = 0;

            foreach(int num in givearray)
            {
                if (num< min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
                sum += num;
                Console.WriteLine(num);
            }
            Console.WriteLine($"Min Value: {min}, Max Value: {max}, Sum of all the Values: {sum}");
            return givearray;

        }
            ////COIN FLIP////
            //Create a function called TossCoin() that returns a string
            //Have the function print "Tossing a Coin!"
            public static string TossCoin()
            {
                Console.WriteLine("Tossing a Coin!");

            //Randomize a coin toss with a result signaling either side of the coin
            Random randidx = new Random();
            int flip = randidx.Next(0, 2);
            string result = "";

            //Have the function print either "Heads" or "Tails"
            if (flip == 0)
            {
                result = "Heads";
            }
            else
            {
                result = "Tails";
            }
            //Finally, return the result
            Console.WriteLine(result);
            return result;
            }

            //Create another function called TossMultipleCoins(int num) that returns a Double
            //Have the function call the tossCoin function multiple times based on num value
            public static Double TossMulitpleCoins(int num)
            {
                int heads = 0;
                int tails = 0;
                for (int i = 0; i < num; i++)
                {
                    string coinToss = TossCoin();
                    if (coinToss == "Heads")
                    {
                        heads++;
                    }
                    else
                    {
                        tails++;
                    }
                    Console.WriteLine($"TossCoin() Returned: {coinToss}, Current Heads: {heads}, Current Tails: {tails}");
                }
                //Have the function return a Double that reflects the ratio of head toss to total toss
                double ratio = (double)heads / num;
                Console.WriteLine($"Head Toss Ratio {ratio}");
                return ratio;
            }

            ////Names////
            //Build a function Names that returns a list of strings.  In this function:
            //Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            public static string[] Names()
            {

                
                string[] nameList= {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};

                for (int i = 0; i < nameList.Length; i++)
                {
                    Random randidx = new Random();
                    int randIdx = randidx.Next(0, nameList.Length-1);
                    string temp = nameList[i];
                    nameList[i] = nameList[randIdx];
                    nameList[randIdx] = temp;
                }
                //Shuffle the list and print the values in the new order
                for (int i = 0; i < nameList.Length; i++)
                {
                    Console.WriteLine(nameList[i]);
                }
                return nameList;
            }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomArray();
            TossCoin();
            TossMulitpleCoins(20);
            Names();
        }
    }
}
