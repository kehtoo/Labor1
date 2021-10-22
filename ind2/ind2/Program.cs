using System;

namespace ind2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a, b;
            double y, z;

            Console.WriteLine("Введите значение x");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Номер 1");

            if (x != 0 && b > 0)
            {
                y = Math.Pow(Math.Sin(x ^ 2 + a), 3) - Math.Sqrt(x / b);
                Console.WriteLine("Ответ первого уравнения:\ny = " + y);
            }
            else Console.WriteLine("Введенные значения не входят в ОДЗ (x != 0 && b > 0)");

            Console.WriteLine("Номер 2");

            if (a != 0)
            {
                z = Math.Pow(x, 2)/a + Math.Pow(Math.Cos(x + b), 3);
                Console.WriteLine("Ответ второго уравнения:\nz = " + z);
            }
            else Console.WriteLine("Введенные значения не входят в ОДЗ (a != 0)");

        }
    }
}
