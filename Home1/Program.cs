using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Home1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Задание 1");
            Console.WriteLine("e=2,7");*/

            /*Console.WriteLine("Задание 2");
              Console.WriteLine("50");
            Console.WriteLine("10");*/

            /*Console.WriteLine("Задание 3");
             Console.WriteLine("50");
            Console.WriteLine("40");
            Console.WriteLine("20");
            Console.WriteLine("0");*/

            /*Console.WriteLine("Задание 4");
            Console.WriteLine("Введите число ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = num1 + 10;
            Console.WriteLine($"Ответ {num2}") ;*/
            
            /*Console.WriteLine("Задание 5");
            double a = 4;
            double P=4*a;
            Console.WriteLine($"Сторона равна {a}, Периметр равен {P}");*/

            /*Console.WriteLine("Задание 6");
            double r = 2.5;
            const double pi=3.14;
            double C = 2 * pi * r;
            double S = pi * r * r;
            Console.WriteLine($"Радиус равен {r}, длина окружности равна {C},Площадь равна {S}");*/

            /*Console.WriteLine("Задание 7");
            double x = 0;
            double y = Math.Cos(x);
            if ((y > -1) | (y == -1) && (y < 1) | (y == 1))
            {
                Console.WriteLine($"Ответ {y}");
            }
            else
            {
                Console.WriteLine("Нет действительных решений");
            } */
                
            /*Console.WriteLine("Задание 8");
            double a = 6;
            double d = 12;
            double h = 4;
            double c2 = ((d - a) / 2) * ((d - a) / 2) + h * h;
            double c = Math.Sqrt(c2);
            double P = a + d + 2 * c;
            Console.WriteLine($"Основания равны {a} и {d}, Высота равна {h}, Периметр равнобедренной трапеции равен {P}");*/

            /*Console.WriteLine("Задание 9");
            double candies = 200;
            double apples = 100;
            double cookies = 50;
            int x = 2;
            int y = 3;
            int z = 4;
            double sum = x * candies + y * cookies + z * apples;
            Console.WriteLine($"1 кг конфет стоит {candies} рублей (взято {x} кг), 1 кг печенья стоит {cookies} рублей (взято {y} кг), 1 кг яблок стоит {apples} рублей (взято {z} кг), Стоимость покупки {sum} рублей");*/

            /*Console.WriteLine("Задание 10");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("     Труд");
            Console.WriteLine("           Май");*/

            /*???????????Console.WriteLine("Задание 11");
            B1:
            Console.Write("Введите первое число ");
            var n1 = Convert.ToChar(Console.ReadLine());
            if(Char.IsAscii(n1))
            {
                Console.WriteLine("Неверный ввод");
                goto B1;
            }
            var n11 = Convert.ToDouble(n1);
            B2:
            Console.Write("Введите второе число ");
            var n2 = Convert.ToChar(Console.ReadLine());
            if (Char.IsAscii(n2))
            {
                Console.WriteLine("Неверный ввод");
                goto B2;
            }
            var n22 = Convert.ToDouble(n2);
            double n = n11;
            n11 = n22;
            n22 = n;
            Console.WriteLine($"Первое число {n11}, Второе число {n22}");*/

            //Console.WriteLine("Задание 12");

            /*Console.WriteLine("Задание 13");
            Console.Write("Введите число ");
            Console.WriteLine("Вы ввели число "+ Console.ReadLine());*/

            /*Console.WriteLine("Задание 14");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");*/

            /*Console.WriteLine("Задание 15");
            Random r1=new Random();
            int n1 = r1.Next();
            int n2 = r1.Next();
            int n3 = r1.Next();
            int n4 = r1.Next();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);*/

            /*Console.WriteLine("Задание 16");
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
                double x = (-b) / 2 * a;
                Console.WriteLine($"Корень уравнения {x}");
            }
            if (discr < 0)
            {
                Console.WriteLine($"Нет действительных корней");
            }*/

            /*Console.WriteLine("Задание 17");
            int a = 12;
            int b = 16;
            double armean = (a + b) / 2;
            double geomean = Math.Sqrt(a * b);
            Console.WriteLine($"Среднее арифметическое {a} и {b} равно {armean}, среднее геометерическое равно {geomean}");*/
            
            /*Console.WriteLine("Задание 18");
            double ax = 3;
            double ay = 4;
            double bx = 5;
            double by = 10;
            double r = Math.Sqrt((bx-ax)*(bx-ax) + (by-ay)*(by-ay));
            Console.WriteLine($"Расстоние между точкой А({ax},{ay}) и точкой В ({bx},{by}) равно {r}");*/
            
            //Console.WriteLine("Задание 19");
            
            //Console.WriteLine("Задание 20");

            /*Console.WriteLine("Задание 21");
            int a = 543;
            int b = 130;
            int d = a / b;
            Console.WriteLine($"Можно отрезать {d} квадрата(ов)");*/

            /*Console.WriteLine("Задание 22");
            Console.WriteLine("Задание 23");
            Console.WriteLine("Задание 24"); 
            Console.WriteLine("Задание 25");
            Console.WriteLine("Задание 26");
            Console.WriteLine("Задание 27");
            Console.WriteLine("Задание 28");
            Console.WriteLine("Задание 29");
            Console.WriteLine("Задание 30");
            Console.WriteLine("Задание 31");
            Console.WriteLine("Задание 32");
            Console.WriteLine("Задание 33");*/ 

            /*Console.WriteLine("Задание 34.1");
            Console.Write("Введите имя ");
            Console.Write(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Задание 34.1");
            Console.Write("Введите имя ");
            Console.Write("Здравствуйте, " + Console.ReadLine());*/

            /*Console.WriteLine("Задание 35");
            Console.WriteLine("Задание 36");*/
        }
    }
}