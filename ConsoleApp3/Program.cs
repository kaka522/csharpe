using System;

namespace ConsoleApp3
{
    class Mammal
    {
        public Mammal(string name)
        {
            Console.WriteLine("Base:" + name);
        }
    }

    class Horse:Mammal
    {
        public Horse(string name):base(name)
        {
            Console.WriteLine("myHorse:" + name);
        }
    }

    class Whale:Mammal
    {
        public Whale(string name) : base(name)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Horse myHorse = new Horse("xiao bai!");
            Console.WriteLine("Hello World!");
        }
    }
}
