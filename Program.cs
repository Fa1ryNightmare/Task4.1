using System;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите E: ");
            double eps = Convert.ToDouble(Console.ReadLine());
            if (x >= 1)
            {
                Console.WriteLine("Ошибка: X > 1");
                Console.Write("Введите X: ");
                x = Convert.ToDouble(Console.ReadLine());
            }
            double S = 0;
            int n = 1;
            while (Math.Abs(((2 * n - 1) * Math.Pow(x, 2 * n + 1)) / ((2 * n) * (2 * n + 1))) > eps)
            {
                S += ((2 * n - 1) * Math.Pow(x, 2 * n + 1)) / ((2 * n) * (2 * n + 1));
                n++;
            }
            Console.WriteLine($"Сумма ряда: {x} + {S}");

            Console.ReadKey();
        }
    }
}
