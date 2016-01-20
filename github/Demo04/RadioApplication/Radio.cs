using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Radio
    {
        public bool IsOn { get; set;  }
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if(value > 9)
                {
                    Console.WriteLine("Too damn high volume, man - set to default volume");
                    volume = 5;
                }
                else if(value < 0)
                {
                    Console.WriteLine("Yoo, too low volume level, bruh - set to default volume");
                }
                else
                {
                    volume = value;
                }
            }
        }
        private double frequency;
        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if(value > 26000.0)
                {
                    Console.WriteLine("Theres no such frequency, man - set to default");
                    frequency = 10000.0;
                }
                else if(value <20000.0 )
                {
                    Console.WriteLine("Theres no such frequency, man - set to default");
                }
                else
                {
                    frequency = value;
                }
            }
        }
    }
}
