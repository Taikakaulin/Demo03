using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.Write("   How many times you want to throw a dice : ");
            input = int.Parse(Console.ReadLine());
            Dice dice = new Dice();
            List<int> numbers = new List<int>();
            for (int i = 0; i < input; i++)
            {
                numbers.Add(dice.DiceRoll());
            }

            Console.WriteLine("the avarage is: " + numbers.Average());
            Console.ReadLine();
        }
    }
}
