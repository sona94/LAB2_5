using System;

namespace LAB2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " +name);
            // problems2 
            int a = Convert.ToInt32 (Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( a* b * c);

            //problem3
            Console.WriteLine("please write your age:");
            string age = Console.ReadLine();
            Console.WriteLine("You look younger than " +age);


        }
    }
}
