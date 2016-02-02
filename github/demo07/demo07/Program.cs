using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo07
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "K";
            System.IO.StreamWriter file = new System.IO.StreamWriter("Person.txt");
            while(true)
            {
                Console.WriteLine("Write some text: ");
                text = Console.ReadLine();
                if(text == "0")
                {
                    break;
                }
                file.WriteLine(text);

            }

            file.Close();

            try
            {
                string source = System.IO.File.ReadAllText("Person.txt");
                System.Console.WriteLine(source);
                Console.ReadLine();
            } catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File Not Found (FileNotFoundException");
            }
           

        }
    }
}
