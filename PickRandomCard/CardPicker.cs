using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCard
{
    internal class CardPicker
    {
        static Random random = new();

        public static string[] PickSomeCards (int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for(int i=0; i<numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int suit = random.Next(1, 5);
            switch (suit)
            {
                case 1: return "Spades";
                case 2: return "Hearts";
                case 3: return "Clubs";
                case 4: return "Diamonds";
            }
            return "Error";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            switch (value)
            {
                case 1: return "Ace";
                case > 1 and < 11: return value.ToString();
                case 11: return "Jack";
                case 12: return "Queen";
                case 13: return "King";
            }
            return "Error";
        }
    }
}
