using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lift lift = new Lift();
            while(true)
            {
                Console.WriteLine("The elevator is now in {0} floor: ", lift.Floor);
                Console.WriteLine("Give a new floor number (1-5) > ");
                lift.Floor = int.Parse(Console.ReadLine());
            }
        }
    }
}
