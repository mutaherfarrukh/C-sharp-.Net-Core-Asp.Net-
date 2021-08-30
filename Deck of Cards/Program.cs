using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    class Program
    {
        class Card
        {
            public string StringVal;
            public string Suit;
            public int Val;

            public Card(int val, string suit, string stringVal)

            {
                StringVal = stringVal;
                Suit = suit;
                Val = val;
                // if (val > 1 &&  val < 11)
                // {
                //     StringVal = val.ToString();///ToString() is a built in method///
                // }
                // else if(val == 1)
                // {
                //     StringVal = "Ace";
                // }
                // else if (val == 11)
                // {
                //     StringVal = "Jack";
                // }
                // else if (val == 12)
                // {
                //     StringVal = "Queen";
                // }
                // else if (val == 13)
                // {
                //     StringVal = "King";
                // }
            }


        }

        class Deck
        {
            public List<Card> cards = new List<Card>();
            string[] suits;
            public Deck()
            {
                ResetDeck();
                Shuffle();
            }

            public Deck ResetDeck()
            {
                cards = new List<Card>();
                string[] suits = {"Spades", "Clubs", "Hearts", "Diamonds"};
                string[] stringVal = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};

                foreach (string suit in suits)
                {
                    for(int i = 0; i < stringVal.Length; i++)
                    {
                        Card noob = new Card(stringVal[i], suit, i+1);
                        cards.Add(noob);
                    }
                }
                return this;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



        }
    }
}
