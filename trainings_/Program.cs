using System;

namespace trainings_
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    class Program
    {
        static void Main()
        {
            Person person = new Person();
            person.Name = "John";
            person.Age = 30;
            person.PrintInfo();
        }
    }
}
