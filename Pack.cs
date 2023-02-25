using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        static List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    new Card { Suit = i, Value = j };
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            switch (typeOfShuffle)
            {
                case 1:
                    Console.WriteLine("Fisher-Yates shuffle");

                    return true;
                case 2:
                    Console.WriteLine("Riffle shuffle");

                    return true;
                case 3:
                    Console.WriteLine("No shuffle");
                    return true;
            }
            return false;
        }
        public static Card deal()
        {
            //Deals one card
            return pack.First();
        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> delt = (List<Card>)pack.Take(amount);
            return delt;
        }
    }
}
