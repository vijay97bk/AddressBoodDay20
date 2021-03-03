using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AddressBookDay20
{
    /// <summary>
    /// Creating Collection
    /// </summary>
    public class AddressBookCollection
    {
        public Dictionary<string, AddressBook> addressBookDictionary;
        /// <summary>
        /// creating new dictionary for city and state for UC8
        /// </summary>
        public Dictionary<string, List<Person>> cityDictionary;
        public Dictionary<string, List<Person>> stateDictionary;
        public AddressBookCollection()
        {
            cityDictionary = new Dictionary<string, List<Person>>();
            stateDictionary = new Dictionary<string, List<Person>>();
            addressBookDictionary = new Dictionary<string, AddressBook>();
        }
        /// <summary>
        /// Printing all address book names
        /// </summary>
        public void PrintAllAddressBookNames()
        {
            foreach (var AddressBookItem in addressBookDictionary)
            {
                Console.WriteLine(AddressBookItem.Key);
            }
        }
        /// <summary>
        /// UC8 searching persons City and state
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void SearchPersonInCityOrState(string firstName, string lastName)
        {
           
            foreach (var addressBookEntry in addressBookDictionary)
            {
                List<Person> PersonInCitiesOrStates = addressBookEntry.Value.addressBook.FindAll(i => (i.firstName == firstName) && (i.lastName == lastName));
                
                //I have to add if condition here to check person exists or not, if not then print "person not exists in addressBook"

                foreach (Person person in PersonInCitiesOrStates)
                {
                    Console.WriteLine($" {person.firstName} {person.lastName} is in {person.city} {person.state}");
                }
            }
        }

        public void ViewPersonsByCityOrState(string cityName, string stateName)
        {
            Console.WriteLine($"People in {cityName} city:");
            foreach (Person person in cityDictionary[cityName])
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }

            Console.WriteLine($"People in {stateName} state:");
            foreach (Person person in stateDictionary[stateName])
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }
           
        }
        public void ViewCountByCityOrState(string city, string state)
        {
            var arrayList = new ArrayList
            {
                "Count of " + city + " is " + cityDictionary[city].Count,
                "Count of " + state + " is " + stateDictionary[state].Count
            };
            Console.WriteLine("Count of  " + city + " is " + cityDictionary[city].Count);
            Console.WriteLine(" Count of " + state + " is " + stateDictionary[state].Count);
        }
    }
}