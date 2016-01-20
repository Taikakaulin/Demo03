using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            while(true)
            {
                Console.WriteLine("The volume level is: {0}", radio.Volume);
                Console.WriteLine("Radio frequency is {0}", radio.Frequency);
                Console.Write("Set the new volume level:> ");
                radio.Volume = int.Parse(Console.ReadLine());
                Console.Write("Set the new frequency:> ");
                radio.Frequency = double.Parse(Console.ReadLine());



            }      
        }
    }
}
