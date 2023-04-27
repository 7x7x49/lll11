
using System;

internal class Program
    {
        delegate string Day();
        static void Main(string[] args)
        {
            string[] array = { "Пон", "Вт", "Ср", "Четв", "Пятн", "Суб", "Вос" };
            int index = -1;

            Day oneDay = () =>
            {
                index = (index + 1) % 7;
                return array[index];
            };

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(oneDay());
            }

            Console.ReadLine();
        }
    }