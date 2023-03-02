using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing //(new) class to test the methods
    {
        private static string card_type(Card card) //(new) method to return the card's name
        {
            string suit = string.Empty;
            string value;
            string card_name;
            switch (card.Suit)
            {
                case 1:
                    suit = "Hearts";
                    break;
                case 2:
                    suit = "Clubs";
                    break;
                case 3:
                    suit = "Dimonds";
                    break;
                case 4:
                    suit = "Spades";
                    break;
            }
            switch (card.Value)
            {
                case 1:
                    value = "Ace";
                    break;
                case 11:
                    value = "Jack";
                    break;
                case 12:
                    value = "Queen";
                    break;
                case 13:
                    value = "King";
                    break;
                default:
                    value = (card.Value).ToString();
                    break;
            }
            card_name = value + " of " + suit;
            return card_name;
        }
        private static bool shuffle() //(new0 method to find out which shuffle to use
        {
            int input;
            Console.WriteLine("1. Fisher-Yates Shuffle");
            Console.WriteLine("2. Riffle Shuffle");
            Console.WriteLine("3. No Shuffle");
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch
            {
                return false; //if user doesn't enter an integer
            }
            return Pack.shuffleCardPack(input); //Returns true if valid input and shuffle completed
        }
        private static bool deal() //(new) method to see how many cards to deal
        {
            int input;
            Console.WriteLine("How many cards do you wont delt?");
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch
            {
                return false; //if user doesn't enter an integer
            }
            if(input == 1)
            {
                Card card = Pack.deal();
                Console.WriteLine(card_type(card));
            }
            else
            {
                if(input < 2 || input > 52)
                {
                    return false; //if user enters an invalid integer
                }
                List<Card> cards = Pack.dealCard(input);
                foreach(Card card in cards)
                {
                    Console.WriteLine(card_type(card));
                }
            }
            return true;
        }
        public static void test()
        {
            new Pack();
            bool valid = true;
            bool valid_shuffle;
            bool valid_deal;
            string input;
            while (valid)
            {
                Console.WriteLine("1. Shuffle");
                Console.WriteLine("2. Deal");
                Console.WriteLine("3. Quit");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        valid_shuffle = shuffle();
                        if(valid_shuffle == false)
                        {
                            Console.WriteLine("Not valid input, please try again");
                        }
                        break;
                    case "2":
                        valid_deal = deal();
                        if(valid_deal == false)
                        {
                            Console.WriteLine("Not valid input, please try again");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Goodbye");
                        valid = false;
                        break;
                }
            }           
        }
    }
}
