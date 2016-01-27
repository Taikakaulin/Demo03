using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    /// <summary>
    /// This class holds persons objects and give a few methdos...
    /// </summary>
    class Persons
    {
        /// <summary>
        /// persons holds person objects.
        /// </summary>
        private List<Person> persons;

        /// <summary>
        /// Default constructor intializes a collection
        /// </summary>

        public Persons()
        {
            persons = new List<Person>();
        }
        /// <summary>
        /// Adds a person to collection
        /// </summary>
        /// <param name="person">Added persons</param>

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        /// <summary>
        /// Returns a person to caller application.
        /// </summary>
        /// <param name="index">Person index in collection</param>
        /// <returns>Returned person object</returns>

        public Person GetPerson(int index)
        {
            if (index < persons.Count) return persons.ElementAt(index);
            else return null;

        }

        public Person FIndPerson(string socialSecurityNumber)
        {
            foreach(Person person in persons)
            {
                if (socialSecurityNumber.Equals(person.SocialSecurityNumber))
                {
                    // Person with sotu found..
                    return person;
                }
            }
            // Person with sotu not found..
            return null;
        }

        public void PrintCollection()
        {
            Console.WriteLine("person in collection: ");
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
