using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1

            Console.WriteLine("Заполните дробное число");
            double x;
            x = double.Parse(Console.ReadLine());
            x = x * 10;
            int d = ((int)x % 10);
            Console.WriteLine(d);

            //Задание 2

            /*Console.WriteLine("Заполните количество секунд:");
            int s;
            s = int.Parse(Console.ReadLine());
            int h = s / 3600;
            int m = (s - (h * 3600)) / 60;
            Console.WriteLine("Прошло " + h + " часов и " + m + " минут");*/

            //Задание 3

            /*Console.WriteLine("Введите часы, минуты и секунды");
            int s, m, h;
            h = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());
            if (s > 60 | m > 60 | h > 12 | s < 0 | m < 0| h < 0)
            {
                Console.WriteLine("Вы вышли за лимит допустимых значений");
            }
            }
            else
            {
                double deg, z;
                z = h + m / 60 + s / 3600;
                deg = z / 12 * 360;
                Console.WriteLine("Угол=" + deg + " градусов");*/

            //Задание 4

            /*int a = 5;
            int b = 7;
            a = a + b - (b = a);
            Console.WriteLine(a);
            Console.WriteLine(b);*/

            //Задание 5

            /*Console.WriteLine("Введите значения 2 катетов");
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            double S = 0.5 * a * b;
            double c = Math.Sqrt(a * a + b * b);
            double p = a + b + c;
            Console.WriteLine("Площадь равна: " + S + " см^2 и периметр равен: " + p + "см");*/

            //Задание 6

            /*Console.WriteLine("Введите число");
            char[] a = Console.ReadLine().ToCharArray();
            int n = 1;
            foreach (char c in a)
                n *= (int)c - 48;
            Console.WriteLine($"Произведение: {n}");*/

            //Задание 7

            /*Console.WriteLine("Введите трёхзначное число: ");
            int x;
            x = int.Parse(Console.ReadLine());
            Console.Write("{0} -> ", x);

            int r = x % 10;
            while ((x /= 10) != 0) r = r * 10 + x % 10;

            Console.WriteLine("{0}", r);*/

            //Задание 8

            /*Console.WriteLine("Введите х:");
            int x, a;
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Упростим выражение и получим:");
            Console.WriteLine("(((3 * x - 5) * x + 2) * x - 1) * x + 7");
            a = (((3 * x - 5) * x + 2) * x - 1) * x + 7;
            Console.WriteLine("X равен = " + a +"");*/

            //Задание 9

            /*double a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3, x, y, z;
            Console.WriteLine("Заполните матрицу:");
            Console.WriteLine("a1 = ");
            a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("a2 = ");
            a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("a3 = ");
            a3 = double.Parse(Console.ReadLine());
            Console.WriteLine("b1 = ");
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("b2 = ");
            b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("b3 = ");
            b3 = double.Parse(Console.ReadLine());
            Console.WriteLine("c1 = ");
            c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("c2 = ");
            c2 = double.Parse(Console.ReadLine());
            Console.WriteLine("c3 = ");
            c3 = double.Parse(Console.ReadLine());
            Console.WriteLine("d1 = ");
            d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("d2 = ");
            d2 = double.Parse(Console.ReadLine());
            Console.WriteLine("d3 = ");
            d3 = double.Parse(Console.ReadLine());

            double del = a1 * b2 * c3 + b1 * c2 * a3 + c1 * a2 * b3 - c1 * b2 * a3 - b1 * a2 * c3 - a1 * c2 * b3;
            double del1 = d1 * b2 * c3 + b1 * c2 * d3 + c1 * d2 * b3 - c1 * b2 * d3 - b1 * d2 * c3 - d1 * c2 * b3;
            double del2 = a1 * d2 * c3 + d1 * c2 * a3 + c1 * a2 * d3 - c1 * d2 * a3 - d1 * a2 * c3 - a1 * c2 * d3;
            double del3 = a1 * b2 * d3 + b1 * d2 * a3 + d1 * a2 * b3 - d1 * b2 * a3 - b1 * a2 * d3 - a1 * d2 * b3;

            if (del != 0)
            {
                x = del1 / del;
                y = del2 / del;
                z = del3 / del;
                Console.WriteLine("x = {0}; y = {1}; z = {2}", x, y, z);
            }
            else Console.WriteLine("Ошибка. Определитель равен нулю.");*/

        }
    }
}
