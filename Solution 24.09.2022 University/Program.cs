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
            Console.Clear();

            Console.WriteLine("Задание 2 \nПрограмма выводит в консоль таблицу умножения на число N\nВведите число N");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Таблица умножения на число " + n);
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(i +" * " + n + " = " + (n * i));
            }
            Console.WriteLine("Для продолжения нажмите enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 3\nПрограмма принимает число выводит информацию о том делиться ли число на некоторые числа\nВведите число");
            double chisl = double.Parse(Console.ReadLine());
            if (chisl % 3 == 0 && chisl % 5 == 0)
            {
                Console.WriteLine("БэнгБум");
            }
            else if ( chisl % 3 == 0)
            {
                Console.WriteLine("Бэнг");
            }
            else if (chisl % 5 == 0)
            {
                Console.WriteLine("Бум");
            }
            else
            {
                Console.WriteLine("Мимо");
            }
            Console.WriteLine("Для продолжения нажмите enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание №4\nПрограмма выполняет проверку на caps\nВведите строку");
            string str = Console.ReadLine();
            Console.WriteLine(str.ToUpper() == str);
            Console.WriteLine("Для продолжения нажмите enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание №5\nПрограмма печатает по шаблону при х = 4: 1 овца ... 2 овца ... 3 овца ... 4 овца ....");
            Console.WriteLine("Введите целое значение х");
            int k = int.Parse(Console.ReadLine());
            string strok = "";
            int a = 0;
            while  ( a < k)
            {
                a++;
                strok += Convert.ToString(a) + " овца ... ";
            }
            Console.WriteLine(strok);
            Console.WriteLine("Для продолжения нажмите enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
        }
    }
}
