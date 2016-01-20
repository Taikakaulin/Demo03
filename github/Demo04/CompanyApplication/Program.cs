using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Pekka";
            employee.LastName = "Pekkanen";
            employee.Profession = "Teacher";
            employee.Profession = 2000;

        }
    }
}
