using System;

namespace Calculator
{
    public delegate double Delegat(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть перше число: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть дiю (+,-,*,/): ");
            string x = Console.ReadLine();

            Console.Write("Введiть друге число: ");
            double b = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case "+":
                    Delegat Add = (c, d) => c + d;
                    double del1 = Add(a, b);
                    Console.WriteLine("Результат: {0}", del1);
                    break;

                case "-":
                    Delegat Sub = (c, d) => c - d;
                    double del2 = Sub(a, b);
                    Console.WriteLine("Результат: {0}", del2);
                    break;

                case "*":
                    Delegat Mul = (c, d) => c * d;
                    double del3 = Mul(a, b);
                    Console.WriteLine("Результат: {0}", del3);
                    break;

                case "/":     
                    Delegat Div = (c, d) => d == 0 ? 0 : c / d;
                    double del4 = Div(a, b);
                    Console.WriteLine("Результат: {0}", del4);
                    break;

                default:
                    Console.WriteLine("Введiть доступну дiю (+,-,*,/).");
                    break;
            }
        }
    }
}
