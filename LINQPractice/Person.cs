using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    internal class Person
    {
        private string _name;

        private int _id;

        private int _age;
        public Person(string name, int id, int age)
        {
            _name = name;
            _id = id;
            _age = age;
        }
        public string Name
        {
            get => _name;
        }
        public int Id
        {
            get => _id;
        }

        public int Age
        {
            get => _age;
        }
               
    }
}
