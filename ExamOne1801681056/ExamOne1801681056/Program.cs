using System;

namespace ExamOne1801681056
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a = random.Next(33,187);
            int b = random.Next(33,187);
            

            Console.WriteLine($"The rectangle random \"a\" is: {a}");
            Console.WriteLine($"The rectangle random \"b\" is: {b}");
            Console.WriteLine($"The area of rectangle is: {a*b}");
        }
    }
}
