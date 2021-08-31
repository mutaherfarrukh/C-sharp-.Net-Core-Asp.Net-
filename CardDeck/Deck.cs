using System;
using System.Collections.Generic;

namespace CardDeck
{
    interface IRandomizable
    {
        void Randomize();

    }
    public class Card
    {
        public string StringVal;
        public string Suit;
        public int Val;
        public Card(string stringVal, string suit, int val)
        {
            StringVal = stringVal;
            Suit = suit;
            Val = val;
        }
    }

    public class Deck: IRandomizable
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            populateDeck();
        }
        private void populateDeck()
        {
            Console.WriteLine("Populate The Deck");

            string[] suits = {"Spade", "Heart", "Diamond", "Club"};
            for(int i = 0; i < suits.Length; ++i)
            {
                for(int val = 1; val <= 13; ++val)
                {
                    // Console.WriteLine(suits[i]);
                    // Console.WriteLine(val);
                    string stringVal;
                    switch(val)
                    {
                        case 1:
                            stringVal = "Ace";
                            break;
                        case 11:
                            stringVal = "Jack";
                            break;
                        case 12:
                            stringVal = "Queen";
                            break;
                        case 13:
                            stringVal = "King";
                            break;
                        default:
                            stringVal = val.ToString();
                            break;
                    }
                    cards.Add(new Card(stringVal, suits[i], val));
                    // Console.WriteLine($"{stringVal} of {suits[i]}s");

                }
            }


        }
        public void PrintDeck()
        {
            foreach(Card card in cards)
            {
                Console.WriteLine($"{card.StringVal} of {card.Suit}s");
            }
        }
        public void Randomize()
        {
            Random rand = new Random();
            for (int i = 0; i < cards.Count; ++i)
            {
                // Console.WriteLine($"Swap card at {i} with card at {rand.Next(cards.Count)}");

                int randIndex = rand.Next(cards.Count);

                Card temp = cards[i];
                cards[i] = cards[randIndex];
                cards[randIndex] = temp;
            }

        }
    }

}