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
            Tyres tyre1 = new Tyres { Name = "nokia", Model = "Hakkapeliitta", Size = "21" };
            Tyres tyre2 = new Tyres { Name = "nokia", Model = "Hakkapeliitta", Size = "18" };
            /*tyre.Name = "nokia";
            tyre.Model = "Hakkapeliitta";
            tyre.Size = "21";*/


            Vehicle vehicle = new Vehicle { Name = "Ferrari", Model = "458" } ;
            /* vehicle.Name = "Ferrari";
             vehicle.Model = "458";*/
            vehicle.AddTyre(tyre1); //car contains tyres..
            vehicle.AddTyre(tyre1);
            vehicle.AddTyre(tyre2);
            vehicle.AddTyre(tyre2);

            Console.WriteLine(vehicle.ToString());





            Console.ReadLine();



        }
    }
}
