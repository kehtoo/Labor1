using System;
using System.Collections;

namespace Table
{
    public class OOP
    {

        public struct Item
        {
            public String Name;
            public String rez;
            public int year;
            public String Type;

            public Item(String Name, String rez, int year, String Type)
            {
                this.Name = Name;
                this.rez = rez;
                this.year = year;
                this.Type = Type;

            }

            public void Print()
            {
                Console.WriteLine($"|{this.Name,-24}||{this.rez,-20}|{this.year,-15}|{this.Type,-12}");

            }
        }

        private static void Main()
        {
            ArrayList list = new();


            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите данные:");

                Console.WriteLine("Фильм:");
                string name = Console.ReadLine();

                Console.WriteLine("Режиссер");
                string rez = Console.ReadLine();

                Console.WriteLine("Год выпуска");
                int year = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Тип фильма (Д - драма, К – комедия, М – мелодрама, Б – боевик, А – мультфильм)");
                string Type = Console.ReadLine();

                Item value = new(name, rez, year, Type);
                list.Add(value);
                while (true)
                {
                    Console.WriteLine("Добавить строку?\nда - продолжить\nнет - вывод таблицы");
                    string input = Console.ReadLine();
                    if (input == "да" || input == "нет")
                    {
                        if (input == "нет")
                        {
                            flag = false;
                            break;
                        }
                        break;
                    }
                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                }

            }
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Кинопродукция",-75}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Фильм",-25}|{"Режиссер",-20}|{"Год выпуска",-15}|{"Тип ",-12}");
            Console.WriteLine(new String('-', 76));
            foreach (Item item in list)
            {
                item.Print();
                Console.WriteLine(new String('-', 76));
            }
            Console.WriteLine($"{"|Перечисляемый тип: Z - зерновые, B - бобовые",-75}|");
            Console.WriteLine(new String('-', 76));
        }

    }
}