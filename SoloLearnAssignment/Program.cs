using System;

namespace SoloLearnAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Joey";
            int number = 12;
            char letter = 'A';
            bool isTrue = true;
            double smallDecimal = 12.9876956;
            decimal price = 12.99m;

            Console.WriteLine($"My name is {name}.\nI am {number} years old.\nMy favorite letter is {letter}.\n1 + 1 = 2 is {isTrue}.\n{smallDecimal} is a float.\nA pizza is ${price}.");


        }
    }
}
