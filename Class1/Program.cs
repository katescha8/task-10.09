using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Упражнение 2.1 Приветствие");
             Console.Write("Введите имя ");
             string name = Console.ReadLine();
             Console.WriteLine($"Привет, {name}");*/

            /*Console.WriteLine("Упражнение 2.2 Деление");
            Console.Write("Введите первое число ");
            double num1 = Convert.ToDouble (Console.ReadLine());
            Begin:
            Console.Write("Введите второе число ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Ошибка!!! Деление на ноль");
                goto Begin;
            }
            double ans = num1 / num2;
            Console.WriteLine($"Ответ: {ans}");*/

            /*Console.WriteLine("Домашнее задание 2.1 Алфавит");
            Console.Write("Введите букву ");
            string a = Console.ReadLine();
            if (a == "а")
            {
              Console.WriteLine("б");
            }
            if (a == "б")
            {
                Console.WriteLine("в");
            }
            if (a == "в")
            {
                Console.WriteLine("г");
            }
            if (a == "г")
            {
                Console.WriteLine("д");
            }
            if (a == "д")
            {
                Console.WriteLine("е");
            }
            if (a == "е")
            {
                Console.WriteLine("ё");
            }
            if (a == "ё")
            {
                Console.WriteLine("ж");
            }
            if (a == "ж")
            {
                Console.WriteLine("з");
            }
            if (a == "з")
            {
                Console.WriteLine("и");
            }
            if (a == "и")
            {
                Console.WriteLine("й");
            }
            if (a == "й")
            {
                Console.WriteLine("к");
            }
            if (a == "к")
            {
                Console.WriteLine("л");
            }
            if (a == "л")
            {
                Console.WriteLine("м");
            }
            if (a == "м")
            {
                Console.WriteLine("н");
            }
            if (a == "н")
            {
                Console.WriteLine("о");
            }
            if (a == "о")
            {
                Console.WriteLine("п");
            }
            if (a == "п")
            {
                Console.WriteLine("р");
            }
            if (a == "р")
            {
                Console.WriteLine("с");
            }
            if (a == "с")
            {
                Console.WriteLine("т");
            }
            if (a == "т")
            {
                Console.WriteLine("у");
            }
            if (a == "у")
            {
                Console.WriteLine("ф");
            }
            if (a == "ф")
            {
                Console.WriteLine("х");
            }
            if (a == "х")
            {
                Console.WriteLine("ц");
            }
            if (a == "ц")
            {
                Console.WriteLine("ч");
            }
            if (a == "ч")
            {
                Console.WriteLine("ш");
            }
            if (a == "ш")
            {
                Console.WriteLine("щ");
            }
            if (a == "щ")
            {
                Console.WriteLine("ъ");
            }
            if (a == "ъ")
            {
                Console.WriteLine("ы");
            }
            if (a == "ы")
            {
                Console.WriteLine("ь");
            }
            if (a == "ь")
            {
                Console.WriteLine("э");
            }
            if (a == "э")
            {
                Console.WriteLine("ю");
            }
            if (a == "ю")
            {
                Console.WriteLine("я");
            }
            if (a == "я")
            {
                Console.WriteLine("Последняя буква алфавита");
            }*/

            Console.WriteLine("Домашнее задание 2.2 Квадратное уравнение");
            Console.Write("Введите а ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите с ");
            double c = Convert.ToDouble(Console.ReadLine());
            double discr = b * b - 4 * a * c;
            if (discr > 0)
            {
                double x1 = (-b + Math.Sqrt(discr)) / 2 * a;
                double x2 = (-b - Math.Sqrt(discr)) / 2 * a;
                Console.WriteLine($"Корни уравнения {x1} и {x2}");
            }
            if (discr == 0)
            {
                double x = (-b ) / 2 * a;
                Console.WriteLine($"Корень уравнения {x}");
            }
            if (discr < 0)
            {
                Console.WriteLine($"Нет действительных корней");
            }
        }
    }
}