﻿using System;
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
            // create an object from Persons
            Persons myFriends = new Persons();

            // create a friends...
            Person person1 = new Person { Firstname = "Mikko", Lastname = "Mallikas", SocialSecurityNumber = "010101-010E" };
            Person person2 = new Person { Firstname = "Henkka", Lastname = "Mäkinen", SocialSecurityNumber = "123456-111T" };
            Person person3 = new Person { Firstname = "Laura", Lastname = "Joulunen", SocialSecurityNumber = "987456-456H" };


            // add persons to collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // print collection
            myFriends.PrintCollection();
            

            // get one person
            Console.WriteLine("get one person from collection: ");
            Person person4 = myFriends.GetPerson(1);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            } else
            {
                Console.WriteLine("Cannot find person in that position...");
            }

            // find person with sotu

            string socialSecurityNumber = "123456-111T";
            Console.WriteLine("Find person with sotu : " + socialSecurityNumber);
            Person person5= myFriends.FIndPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            } else
            {
                Console.WriteLine("Not found...");
            }


        }

    }
}
