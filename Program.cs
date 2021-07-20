using System;

namespace Qwest_console
{
    class Dice
    {
        public static int D20()
        {
            Random rnd = new Random();
            int d20 = rnd.Next(1, 20);
            return d20;
        }
        public static int D8()
        {
            Random rnd = new Random();
            int d8 = rnd.Next(1, 8);
            return d8;
        }
        public static int D10()
        {
            Random rnd = new Random();
            int d10 = rnd.Next(1, 10);
            return d10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("After stepping through the basement door you see smiled  old mouse with red fur and grey cape.\nHe was reading some letter, but when you came - he hid it and looked at you.");
            Console.ReadKey(true);
            Console.WriteLine("Hello Little Mouse! My name's Redmand\nAnd what is yours?");
            string Name = Console.ReadLine();
            Console.WriteLine("So, " + Name + ", in this dim light I can't see what color of your fur. What is it?");
            string Fur = Console.ReadLine().ToLower();
            Console.WriteLine("Oh, " + Fur + " fur. Yeah, I knew few folks with that color.");
            switch (Fur)
            {
                case "red":
                    Console.WriteLine("There was one redfur that had outstanding might. Once he become Guard he slayed snake and owl in two seasons.");
                    break;
                case "grey":
                    Console.WriteLine("One bluefur folk was the master of mind and staff.");
                    break;
                case "white":
                    Console.WriteLine("blbalbalbalablba");
                    break;
                case "brown":
                    Console.WriteLine("balblabbla");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }
            int d20 = Dice.D20();
            int d8 = Dice.D8();
            int d10 = Dice.D10();
            Console.WriteLine(d20 + ", " + d8 + ", " + d10);
        }
    }
}
