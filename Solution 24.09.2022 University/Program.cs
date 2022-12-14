using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_24._09._2022_University
{
    public enum day
    {
        понедельик = 1,
        вторник = 2,
        среда = 3,
        четверг = 4,
        пятница = 5,
        суббота = 6,
        воскресенье = 7
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1\nПрограмма принмает три зачениея ширину, высоту окна также длину поперечного сечения головы Васи и проверяет сможет ли Вася высунуть голову в окно таких габаритов");
            Console.WriteLine("Введите длину окна ");
            string st1 = Console.ReadLine();
            Console.WriteLine("Введите ширину окна");
            string st2 = Console.ReadLine();
            Console.WriteLine("Введите диаметр окружности головы Васи");
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

            try
            {
                Console.WriteLine("Задание №6\nПрограмма находит среднее арифметическое не без последнего члена ");
                List<int> non = new List<int>();
                string n_at_a;
                int m;
                int endelem;
                int srnon;
                do
                {
                    Console.WriteLine("Если вы хотите ввести число, то введите 'a' иначе любой другой символю");
                    n_at_a = Console.ReadLine();
                    if (n_at_a == "a" || n_at_a == "а") // это разные а латинская и русская
                    {
                        Console.WriteLine("Введите число. Нообходимо вводить натуральные числа и ноль.\nЗнак последнего введенного числа будет изменен на отрицательный");
                        m = int.Parse(Console.ReadLine());
                        if (m >= 0)
                        {
                            non.Add(m);
                        }
                        else
                        {
                            Console.WriteLine("Введенное число не является натуральным или нулем");
                        }
                    }
                }
                while (n_at_a == "a" || n_at_a == "a");
                endelem = non[non.Count - 1];
                non.RemoveAt(non.Count - 1);
                srnon = (non.Sum() / non.Count());
                Console.WriteLine(srnon);
            }
            catch
            {
                Console.WriteLine("Вы что-то делаете не так ( возникло исключение)");
            }
            finally
            {
                Console.WriteLine("Для продолжения нажмите enter");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Задание №7\nПрограмма получает числовое значение карты и возвращает ее название\nВведите число принадлежащее [6 ; 14]");
            try
            {
                int cart = int.Parse(Console.ReadLine());
                List<string> carts = new List<string>() { "0", "1", "2", "3", "4", "5", "шесть", "семь", "восемь", "девять", "десять", "валет", "дама", "король", "туз" };
                if (cart >= 6 && cart <= 14)
                {
                    Console.WriteLine(carts[cart]);
                }
                else
                {
                    Console.WriteLine("Вы ввели число не принадлежащее [6 ; 14]");
                }
            }
            catch
            {
                Console.WriteLine("возникло исключение");
            }
            finally
            {
                Console.WriteLine("Для продолжения нажмите enter");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Задание №8\nПрограмма считает количество определенных элементов в массиве");
            int count_c = 0;
            string count_el = "";
            string[] cucl = { "(Hello Kitty)", "(wfdfwdg)", "(efwefwef)", "(Hello Kitty)", "(Hello Kitty)", "(2r2erfewfw)", "(2erwefw)", "(Barbie doll)", "(efw)", "(Barbie doll)", "(weqre11111111)" };
            foreach (string i in cucl)
            {
                count_el += i + " ";
                if (i == "Hello Kitty" || i == "Barbie doll")
                {
                    count_c++;
                }
            }
            Console.WriteLine("Элементы массива:\n" + count_el);
            Console.WriteLine("В сумке " + count_c + " кукол");
            Console.WriteLine("Для продолжения нажмите enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание № 9\nПрограмма выводит день недели по соответствующему его номеру\nВведите номер дня недели");
            int mainday = int.Parse(Console.ReadLine());
            Console.WriteLine(Enum.GetName(typeof(day), mainday));
            Console.ReadKey();
            Console.Clear();

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

            Console.WriteLine("Заданеи № 11\nПрограмма проверяет стоят ли эелементы массива в порядке возрастания и в случае отрицательного ответа пишет номер первого элемента стоящего не в порядке возрастания");
            int[] spis = { -34213, -4234, -245, 34, 84, 92, -3, 34, 75, 10 };
            string at_spis = "";
            foreach (int i in spis)
            {
                at_spis += Convert.ToString(i) + " ";
            }
            Console.WriteLine("Массив состоит из элементов " + at_spis);
            spis.Append(0);
            for (int i = 0; i < spis.Count() - 1; i++)
            {
                if (spis[i] < spis[i + 1])
                {
                    continue;
                }
                else
                {
                    spis[spis.Length - 1] = i + 1;
                    break;
                }
            }
            if (spis[spis.Length - 1] == 0)
            {
                Console.WriteLine("Все элементы массива стоят по возрастанию");
            }
            else
            {
                Console.WriteLine("Элементы массива возрастают до элемента с индексом " + spis[spis.Length - 1]);
            }
            Console.WriteLine("Для завершения нажмите enter");
            Console.ReadKey();
        }
    }
}
