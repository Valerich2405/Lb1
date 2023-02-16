using System;

namespace MiddleNumber
{
    class Program
    {
        static void MidCalc(int a, int b, int c)
        {
            Console.WriteLine($"Результат: " + ((a+b+c)/3));
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть перше число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введiть друге число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введiть третє число: ");
            int c = int.Parse(Console.ReadLine());

            MidCalc(a, b, c);
        }
    }
}
