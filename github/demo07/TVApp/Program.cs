using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shows> shows = new List<Shows>();
            shows.Add(new Shows { Name = "The Simpsons", Channel = "Sub tv", Start = 20.30, End = 21.00, Info = "A very good show lads!" });
            Stream writeMultipleStream = new FileStream("TvShows.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeMultipleStream, shows);
            writeMultipleStream.Close();

            Stream openstream = new FileStream("TvShows.bin", FileMode.Open, FileAccess.Read, FileShare.None);

            List<Shows> readShow = (List<Shows>)formatter.Deserialize(openstream);
            foreach(Shows show in shows)
            {
                Console.WriteLine(show);
            }
            Console.ReadLine();
        }
    }
}
