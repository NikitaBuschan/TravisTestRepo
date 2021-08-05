using System;

namespace TravisTest
{
    public class A
    {
        public string name { get; set; }
        public string surname { get; set; }

        public A()
        {
            name = "Nikita";
            surname = "Bushchan";
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("have a good day");
            var nikita = new A();
            Console.WriteLine($"Name: {nikita.name}, surname: {nikita.surname}");
            int
        }
    }
}
