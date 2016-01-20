using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmplifierApplication
{
    class Amplifier
    {
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Can't support this volume level - set to default volume level");
                    volume = 50;
                }
                else if(value < 0 )
                {
                    Console.WriteLine("Can't support this volume level - set to default volume level");
                    volume = 50;
                }
                else
                {
                    volume = value;
                }
            }
        }
    }
}
