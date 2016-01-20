using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmplifierApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier machine = new Amplifier();
            while(true)
            {
                Console.WriteLine("Welcome to the Pavels Amplifier!");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("The Volume Level is {0} ", machine.Volume);
                Console.WriteLine("--------------------------------");
                Console.Write("Set The New Volume Level, Please:> ");
                machine.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
