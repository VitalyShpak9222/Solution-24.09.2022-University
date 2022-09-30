using System;

namespace KW
{
    class Program
    {
        static int tasktwo( int chisl)
        {
            int k;
            if (chisl % 400 == 0 || (chisl % 4 == 0 && chisl % 100 != 0))
            {
                k = 60;
            }
            else
            {
                k = 59;
            }
            return k;
        }
        static void Main(string[] args)
        {
            string prov = "1";
            while (prov == "1")
            {
                Console.WriteLine("Если хотете проверить задания нажмите 1, иначе любую другую клавишу");
                prov = Console.ReadLine();
                if (prov != "1")
                {
                    break;
                }
                Console.WriteLine("Введите номер соответствующий заданию, которое хотите проверить");
                int solution = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер дня");
                int numday = int.Parse(Console.ReadLine());
                int m = 59;
                int age;
                if (solution == 1)
                {
                    Console.WriteLine("Задание №1\nПрограмма принимает значение от 1 до 365 включително и выводит соответствующие месяц и число");
                }
                if (solution == 2)
                {
                    Console.WriteLine("Задание №2\nПрограмма дополняет программу задания №1 проверкой на вхождение числа в календарный год");
                    if (numday < 1 || numday > 365)
                    {
                        Console.WriteLine("Вы ввели некоректное число");
                        m = 600;
                    }
                }
                if (solution == 3)
                {
                    Console.WriteLine("Задание №3\nПрограмма объединяет задания №1,№2 и дополняет их проверкой года на высокостность \nВведите номер года");
                    age = Convert.ToInt32(Console.ReadLine());
                    m = tasktwo(age);
                    if (m == 60 && (numday < 1 || numday > 366))
                    {
                        Console.WriteLine("Вы ввели некоректное число");
                        numday = 600;
                    }
                    if (m == 59 && (numday < 1 || numday > 365))
                    {
                        Console.WriteLine("Вы ввели некоректное число");
                        numday = 600;
                    }
                }
                if (1 <= numday && numday <= 31)
                {
                    Console.WriteLine(numday + " января");
                }
                else if (31 < numday && numday <= m)
                {
                    Console.WriteLine((numday - 31) + " февраля ");
                }
                else if (m < numday && numday <= (m + 31))
                {
                    Console.WriteLine((numday - m) + " марта");
                }
                else if ((m + 31) < numday && numday <= (m + 61))
                {
                    Console.WriteLine((numday - (m + 31)) + " апреля");
                }
                else if ((m + 61) < numday && numday <= (m + 92))
                {
                    Console.WriteLine((numday - (m + 61)) + " мая");
                }
                else if ((m + 92) < numday && numday <= (m + 122))
                {
                    Console.WriteLine((numday - (m + 92)) + " июня");
                }
                else if ((m + 122) < numday && numday <= (m + 153))
                {
                    Console.WriteLine((numday - (m + 122)) + " июля");
                }
                else if ((m + 153) < numday && numday <= (m + 184))
                {
                    Console.WriteLine((numday - (m + 153)) + " августа");
                }
                else if ((m + 184) < numday && numday <= (m + 214))
                {
                    Console.WriteLine((numday - (m + 184)) + " сентября");
                }
                else if ((m + 214) < numday && numday <= (m + 245))
                {
                    Console.WriteLine((numday - (m + 214)) + " октября");
                }
                else if ((m + 245) < numday && numday <= (m + 275))
                {
                    Console.WriteLine((numday - (m + 245)) + " ноября");
                }
                else if ((m + 275) < numday && numday <= (m + 306))
                {
                    Console.WriteLine((numday - (m + 275)) + " декабря");
                }
                Console.WriteLine("Дзя продолжения нажмите enter");
                Console.ReadKey();
                Console.Clear();
            }

          


        }
    }
}
