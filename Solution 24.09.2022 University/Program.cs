using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_24._09._2022_University
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1\nПрограмма принмает три зачениея ширину, высоту окна также длину поперечного сечения головы Васи и проверяет сможет ли Вася высунуть голову в окно таких габаритов");
            Console.WriteLine("Введите длину окна ");
            string st1 = Console.ReadLine();
            Console.WriteLine("Введите ширину окна");
            string st2 = Console.ReadLine();
            string g = Console.ReadLine();
            if (Math.Min(double.Parse(st1), double.Parse(st2)) - double.Parse(g) >= 2)
            {
                Console.WriteLine("Голова Васи проходит");
            }
            else
            {
                Console.WriteLine("Голова Васи не проходит");
            }
            Console.WriteLine("Для продолжения нажмите enter");
            Console.ReadKey();

            Console.WriteLine("Задание 2 \nПрограмма выводит в консоль таблицу умножения на число N\nВведите число N");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Таблица умножения на число " + n);
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(n * i);
            }
            Console.WriteLine("Для продолжения нажмите enter");
            Console.ReadKey();
        }
    }
}
