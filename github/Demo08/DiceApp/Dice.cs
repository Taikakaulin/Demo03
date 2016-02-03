using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceApp
{
    class Dice
    {
        List<int> Number = new List<int>();
        public int DiceRoll()
        {
           
            Random rnd = new Random();

            return rnd.Next(0, 7);
            
        }
    }
}
