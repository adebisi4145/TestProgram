using System;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your name" );

            string name = Console.ReadLine();

            Console.Write("what is your favourite colour" );

            string colour = Console.ReadLine();

            string colou = Console.ReadLine();


            Console.WriteLine($"Hello {name} {colour} ");
            
        }
    }
}
