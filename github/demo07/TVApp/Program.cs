using System;
using System.IO;
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
            Stream WriteMultipleStream = new FileStream("TvShows.bin", FileMode.Create, FileAccess.Write, FileShare.None);
           IFormatte formatter.Serialize(WriteMultipleStream, shows);
            WriteMultipleStream.Close();

            Stream openstream = new FileStream("TvShows")
        }
    }
}
