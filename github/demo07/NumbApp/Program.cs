using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Integers;
            double Doubles;
            string text;
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"T2Integers.txt");
            System.IO.StreamWriter file2 = new System.IO.StreamWriter(@"T2Doubles.txt");
            do
            {
                Console.Write("Give a number: ");
                text = Console.ReadLine();
                if (int.TryParse(text, out Integers))
                {
                    file.WriteLine(Integers);
                }

                else if(double.TryParse(text, out Doubles))
                {
                    file2.WriteLine(Doubles);
                }



            }
            while (!string.IsNullOrEmpty(text));
            file.Close();
            file2.Close();

            String[] lines = System.IO.File.ReadAllLines(@"T2Integers.txt");
            Console.WriteLine("T2Integers.txt:\n");
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            string[] lanes = System.IO.File.ReadAllLines(@"T2Doubles.txt");
            Console.WriteLine("T2Doubles.txt:\n");
            foreach(string lane in lanes)
            {
                Console.WriteLine(lane);

            }
            Console.ReadLine();





        }
    }
}
