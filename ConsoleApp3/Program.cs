using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    enum WeekDay
    {
         Monday = 1,  Tuesday = 2,  Wednesday = 3, Thursday = 4,  Friday = 5,  Saturday = 6, Sunday = 7
    }
    class Program
    {
        static void Main(string[] args)
        {
            WeekDay wd;
            int dayNum;
            wd = WeekDay.Friday;
            Console.WriteLine($"Пример дня недели: {wd}");
            dayNum = (int)wd;
            Console.WriteLine($"{wd} идет в перечислении под номером {dayNum}");
            wd -= 3;
            dayNum = (int)wd; Console.WriteLine($"{wd} идет в перечислении под номером {dayNum}");
            Console.WriteLine(Enum.GetName(typeof(WeekDay), 7);
            Console.ReadKey();
        }
    }
}
