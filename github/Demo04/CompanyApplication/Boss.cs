using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApplication
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public Boss(string firstname, string lastname, string car, int bonus)
            :base(firstname, lastname)
        {
            Car = car;
            Bonus = bonus;

        }
        public override string ToString()
        {
            return base.ToString() + " " + Car + " " + Bonus;
        }


    }
}
