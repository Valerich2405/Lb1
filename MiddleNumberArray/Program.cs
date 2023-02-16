using System;

namespace MiddleNumberArray
{
    class Program
    {
        delegate int MyDelegate();
        delegate double MidCalc(MyDelegate[] a);

        static int Randomize()
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            Console.WriteLine(number);
            return number;
        }

        static void Main()
        {
            Console.Write("Введiть кiлькiсть елементiв масива: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Згенерований масив:");
            var array = new MyDelegate[x];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegate(Randomize)();
            }

            MidCalc calc = delegate (MyDelegate[] a)
            {
                double sr = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sr += a[i]();
                }
                return sr / array.Length;
            };

            Console.WriteLine($"Середнє арифметичне значення = " + calc(array));
            Console.WriteLine();

        }
    }
}
