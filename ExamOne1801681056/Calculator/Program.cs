using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(@"Choose an option: +, -, *, /");
            string option = Console.ReadLine();

            switch (option)
            {

              case "+":

               double sum = a + b;
                    double withPercentage = sum + (sum*0.1);
                    Console.WriteLine($"{withPercentage}");
                break;

              case "-":

               double minus = a - b;
                    if (a > b)
                    {
                        double aSquared = Math.Pow(a, 2);
                        double minus1 = aSquared - b;
                        Console.WriteLine($"{minus1}");
                    }
                   else if (b > a)
                    {
                        double bSquared = Math.Pow(b, 2);
                        double minus2 = bSquared - a;
                        Console.WriteLine($"{minus2}");
                    }
                    break;

                case "*":

                    double multipl = a * Math.Sqrt(b);
                    Console.WriteLine($"{multipl}");
                    break;

                case "/":
                   double division = a/b;
                    Console.WriteLine($"{division}");
                    if (a==0)
                    {
                        Console.WriteLine("There is no solution!");
                    }
                    else if (b==0)
                    {
                        Console.WriteLine("There is no solution!");
                    }
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;







            }

           ;
        }
    }
}
