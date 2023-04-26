using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SortList
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Person alessio = new Person { Name = "Alessio", Surname = "Presciuttini" };
            Person matteo = new Person { Name = "Matteo", Surname = "Luccisano" };
            Person cristina = new Person { Name = "Cristina", Surname = "Zappala" };
            Person fausto = new Person { Name = "Fausto", Surname = "Boshoff" };

            List<Person> people = new List<Person>
            {
                alessio,
                matteo,
                cristina,
                fausto
            };
            // ordina in maniera creascente in funzione del nome 
           List<Person> sortedPeople =  SortList(people,p=>p.Name);

            // check del risultato 
            foreach(Person person in sortedPeople)
            {
                Console.WriteLine(person.Name);
            }
           // ordina in maniera decrescente in funzione del nome 

            List<Person> sortedPeopleDesc = SortListDesc(people, p => p.Name);

            //check del risultato 
            foreach (Person person in sortedPeopleDesc)
            {
                Console.WriteLine($"{person.Name}");
            }

            //ordina lista di interi 
            
            List<int> listint = new List<int>() { 1, 3, 4,6 };
           List<int> orderedListint = SortList(listint, l=>l );

            //check del risultato 
            for (int i = 0; i < orderedListint.Count; i++) { Console.WriteLine(orderedListint[i]);}


        }

        public static List<T> SortList<T, Tkey>( List <T> list, Func<T, Tkey> property)
        {
            
             var sortedList = list.OrderBy(property).ToList();
            

            
           
            return sortedList;
        }
        public static List<T> SortListDesc<T, Tkey>(List<T> list, Func<T, Tkey> property)
        {

            var sortedList = list.OrderByDescending(property).ToList();




            return sortedList;
        }


        public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string CF { get; set; }
        }
    }
}
