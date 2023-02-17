using System;

namespace Calculator
{
    public delegate double Delegat(double a, double b);
    public delegate void Action();
    public delegate void Action<in T>(T obj);

    class Program
    {
        static void Main(string[] args)
        {
            void DoCalculation(double a, double b, Action<double, double> op) => op(a, b);
            void Add(double x, double y) => Console.WriteLine($"{x} + {y} = {x + y}");
            void Sub(double x, double y) => Console.WriteLine($"{x} - {y} = {x - y}");
            void Mul(double x, double y) => Console.WriteLine($"{x} * {y} = {x * y}");
            void Div(double x, double y) => Console.WriteLine($"{x} / {y} = {x / y}");

            Console.Write("Введiть перше число: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть дiю (+,-,*,/): ");
            string x = Console.ReadLine();

            Console.Write("Введiть друге число: ");
            double b = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case "+":
                    DoCalculation(a, b, Add);
                    break;

                case "-":
                    DoCalculation(a, b, Sub);
                    break;

                case "*":
                    DoCalculation(a, b, Mul);
                    break;

                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("На нуль дiлити не можна!");
                    }
                    else
                    {
                        DoCalculation(a, b, Div);
                    }
                    break;

                default:
                    Console.WriteLine("Введiть доступну дiю (+,-,*,/).");
                    break;
            }
        }
    }
}
