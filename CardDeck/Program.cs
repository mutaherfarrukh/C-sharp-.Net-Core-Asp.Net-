using System;

namespace CardDeck
{
            class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deck myDeck = new Deck();
            myDeck.Randomize();

            myDeck.PrintDeck();
        }
    }
}



