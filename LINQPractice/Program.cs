using System;
using System.Drawing;

namespace LINQPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(1, 101));
                //Filling in collection with random values
            }
            Console.WriteLine("Generated random numbers:");

            foreach (int number in list)
            {
                Console.Write(number + " ");   //Output to Console the initial collection
            }
            Console.WriteLine();
            Console.WriteLine();


            var result = list.Where(x => x % 2 != 0).Select(x => x * x).ToList();

            foreach (int number in result)
            {
                Console.Write(number + " ");   //Output to Console the initial collection
            }
            Console.WriteLine();

            var result1 = list.Where(x => x % 2 != 0).Select(x => x * x).Sum();

            Console.WriteLine($"Result = {result1}");


            List<Person> personList = new List<Person>();

            Person person1 = new Person("Angela", 1, 25);
            personList.Add(person1);
            Person person2 = new Person("Boris", 2, 17);
            personList.Add(person2);
            Person person3 = new Person("Jackson", 3, 8);
            personList.Add(person3);
            Person person4 = new Person("Dorian", 4, 36);
            personList.Add(person4);
            Person person5 = new Person("Alexander", 5, 50);
            personList.Add(person5);
            Person person6 = new Person("Harry", 6, 11);
            personList.Add(person6);
            Person person7 = new Person("Pavel", 7, 71);
            personList.Add(person7);
            Person person8 = new Person("Roman", 8, 33);
            personList.Add(person8);
            Person person9 = new Person("Vanessa", 9, 15);
            personList.Add(person9);
            Person person10 = new Person("Anna", 10, 9);
            personList.Add(person10);
            Person person11 = new Person("Marta", 11, 45);
            personList.Add(person11);
            Person person12 = new Person("Andzej", 12, 27);
            personList.Add(person12);
            Person person13 = new Person("Sigrid", 13, 28);
            personList.Add(person13);
            Person person14 = new Person("Gry", 14, 6);
            personList.Add(person14);
            Person person15 = new Person("Elena", 15, 55);
            personList.Add(person15);
            Person person16 = new Person("Helen", 16, 22);
            personList.Add(person16);
            Person person17 = new Person("Helena", 17, 64);
            personList.Add(person17);
            Person person18 = new Person("Tracy", 18, 12);
            personList.Add(person18);
            Person person19 = new Person("PerOve", 19, 11);
            personList.Add(person19);
            Person person20 = new Person("Martin", 20, 47);
            personList.Add(person20);

            var result2 = personList.Where(x => x.Age > 20);

            foreach (var person in result2)
            {
                Console.WriteLine($"Name: {person.Name} Age: {person.Age} ");   //Output to Console the initial collection
            }
            Console.WriteLine();

            var result3 = personList.Where(x => x.Age > 20).Select(x => new { Id = x.Id, Name = x.Name }).OrderBy(x => x.Name);

            foreach (var person in result3)
            {
                Console.WriteLine($"Id: {person.Id} Name: {person.Name} ");   //Output to Console the initial collection
            }
            Console.WriteLine();

            try
            {
                var result4 = result3.FindBeforeLastItem();

                Console.WriteLine($"Id: {result4.Id} Name: {result4.Name} ");
            }
            catch
            {
                throw new ArgumentNullException("The before last item is NULL ");
            }

        }    
    }
}