using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your favorite subject?");
            int favSubject = int.Parse(Console.ReadLine());
            switch (favSubject)
            {
                case 0:
                    Console.WriteLine("Math");
                    break;
                case 1:
                    Console.WriteLine("English");
                    break;
                case 2:
                    Console.WriteLine("Science");
                    break;
                case 3:
                    Console.WriteLine("History");
                    break;
                case 5:
                    Console.WriteLine("Gym");
                    break;
            }

        }
    }
}
