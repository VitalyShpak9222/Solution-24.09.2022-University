using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  enum day
    {
        Monday = 1,
        tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание № 9\nПрограмма выводит день недели по соответствующему его номеру\nВведите номер дня недели");
            int mainday = int.Parse(Console.ReadLine());
            Console.WriteLine(Enum.GetName(typeof(day), mainday));
            Console.ReadKey();
            Console.Clear();

        }
    }
}
