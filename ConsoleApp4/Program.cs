using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №10\nПрограмма выполняет сортировку массива");
            int[] mass = { 2, -243, 23242, 242, -2324 };
            Console.WriteLine("Массив до сортировки");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            Array.Sort(mass);
            Console.WriteLine("Массив после сортировки");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            Console.WriteLine("Для продолжения нажмите enter");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
