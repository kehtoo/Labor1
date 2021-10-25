using System;

namespace ind2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, z, x, m, c, b, a;
            double e = 2.72;

            Console.WriteLine("Введите значение x");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение m");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение c");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Номер 1");

            if (x > 0 && m > 0)
            {
                z = Math.Sin(x)/Math.Sqrt(Math.Pow(m, 2) + Math.Pow(Math.Sin(x), 2)) - c * m * Math.Log(m * x);
                Console.WriteLine("Ответ первого уравнения:\ny = " + z);
            }
            else Console.WriteLine("Введенные значения не входят в ОДЗ (x != 0 && b > 0)");

            Console.WriteLine("Номер 2");

            if (x >= 0)
            {
                s = Math.Pow(e, -a * x) * Math.Sqrt(x + 1) + Math.Pow(e, -b * x) * Math.Sqrt(x + 1.5);
                Console.WriteLine("Ответ второго уравнения:\nz = " + s);
            }
            else Console.WriteLine("Введенные значения не входят в ОДЗ (a != 0)");

        }
    }
}
