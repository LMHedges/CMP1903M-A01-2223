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
            //Creates the pack
            pack = new List<Card>();
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    pack.Add(new Card { Suit = i, Value = j });
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
                    Random R = new Random();
                    int k;
                    Card temp;
                    for(int i = pack.Count - 1; i > 0; i--)
                    {
                        k = R.Next(i + 1);
                        temp = pack[i];
                        pack[i] = pack[k];
                        pack[k] = temp;
                    }
                    return true;
                case 2:
                    Console.WriteLine("Riffle shuffle");
                    Card[] pile1 = new Card[26];
                    Card[] pile2 = new Card[26];
                    List<Card> temp_pack = new List<Card>();
                    for (int i = 0; i < 26; i++) //splits pack in two
                    {
                        pile1[i] = pack[i];
                        pile2[i] = pack[i+26];
                    }
                    int count = 0;
                    while(count < 26)
                    {
                        temp_pack.Add(pile1[count]);
                        temp_pack.Add(pile2[count]);
                        count++;
                    }
                    pack = temp_pack;
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
            IEnumerable<Card> enumerable = pack.Take(amount);
            List<Card> cards = enumerable.ToList();
            return cards;
        }
    }
}
