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

            /*Console.WriteLine("Задание 12");
            Console.Write("Выберите фигуру: (треугольник(введите т), четырехугольник(введите ч), круг)(введите к): ");
            string figure = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Выберите искомую величину: площадь(введите s), периметр(введите p): ");
            string value = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Введите сторону а ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите сторону b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите сторону c ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите сторону d ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите высоту h ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите радиус r ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            switch (figure)
            {
                case "т": 
                     if(value=="s")
                        {
                            double st = a * h / 2;
                            Console.WriteLine("Площадь треугольника "+ st);
                            Console.WriteLine("Искомые величины других фигур: ");
                            double sq = a * h;
                            Console.WriteLine("Площадь четырехугольника " + sq);
                            double sc = 3.14 * r * r;
                            Console.WriteLine("Площадь круга " + sc);
                    }
                     if (value == "p")
                        {
                            double pt = a + b + c; 
                            Console.WriteLine("Периметр треугольника " + pt);
                        Console.WriteLine("Искомые величины других фигур: ");
                        double pq = a + b + c + d;
                        Console.WriteLine("Периметр четырехугольника " + pq);
                        double pc = 2 * 3.14 * r;
                        Console.WriteLine("Периметр круга " + pc);
                    }
                    break;
                case "ч":
                    if (value == "s")
                    {
                        double sq = a * h;
                        Console.WriteLine("Площадь четырехугольника " + sq);
                        Console.WriteLine("Искомые величины других фигур: ");
                        double st = a * h / 2;
                        Console.WriteLine("Площадь треугольника " + st);
                        double sc = 3.14 * r * r;
                        Console.WriteLine("Площадь круга " + sc);
                    }
                    if (value == "p")
                    {
                        double pq = a + b + c + d;
                        Console.WriteLine("Периметр четырехугольника " + pq);
                        Console.WriteLine("Искомые величины других фигур: ");
                        double pt = a + b + c;
                        Console.WriteLine("Периметр треугольника " + pt);
                        double pc = 2 * 3.14 * r;
                        Console.WriteLine("Периметр круга " + pc);
                        Console.WriteLine("Искомые величины других фигур: ");
                    }
                    break;
                case "к":
                    if (value == "s")
                    {
                        double sc = 3.14 * r * r;
                        Console.WriteLine("Площадь круга " + sc);
                        Console.WriteLine("Искомые величины других фигур: ");
                        double st = a * h / 2;
                        Console.WriteLine("Площадь треугольника " + st);
                        double sq = a * h;
                        Console.WriteLine("Площадь четырехугольника " + sq);
                    }
                    if (value == "p")
                    {
                        double pc = 2 * 3.14 * r;
                        Console.WriteLine("Периметр круга " + pc);
                        Console.WriteLine("Искомые величины других фигур: ");
                        double pt = a + b + c;
                        Console.WriteLine("Периметр треугольника " + pt);
                        double pq = a + b + c + d;
                        Console.WriteLine("Периметр четырехугольника " + pq);
                    }
                    break;
            }
            */

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

            /*Console.WriteLine("Задание 19");
            int a = 10;
            int b = 50;
            int c = 100;
            Console.WriteLine($"Сначала а={a}, b={b}, c={c}");*/

            /*Console.WriteLine("Задание 19.1");
            int n1 = b;
            b = c;
            int n2 = a;
            a = n1;
            c = n2;
            Console.WriteLine($"После обмена а={a}, b={b}, c={c}");*/

            /*Console.WriteLine("Задание 19.2");
            int n1 = b;
            b = a;
            int n2 = c;
            c = n1;
            a = n2;
            Console.WriteLine($"После обмена а={a}, b={b}, c={c}");*/

            /*Console.WriteLine("Задание 20");
            int n = 12672;
            int h = n / 3600;
            int m = (n - 3600 * h) / 60;
            int s = n - 3600 * h - m * 60;
            Console.WriteLine($"С начала суток прошло {n} секунд, с начала суток прошло {h} полных часов, с начала очередного часа прошло {m} полных минут, с начала очередной минуты прошло {s} полных секунд");*/

            /*Console.WriteLine("Задание 21");
            int a = 543;
            int b = 130;
            int d = a / b;
            Console.WriteLine($"Можно отрезать {d} квадрата(ов)");*/

            /*Console.WriteLine("Задание 22");
            double a = 123;
            double c = a % 10;
            double numb1 = c * 100;
            double numb2 = Math.Truncate(a / 100);
            double numb3 = a - 100 * numb2;
            double numb4 = (numb3 - c) / 10;
            double n = numb1+ 10 * numb2 + numb4;
            Console.WriteLine($"Начальное число {a}, преобразованное число {n}");*/

            /*Console.WriteLine("Задание 23");
            int n = 12557395;
            int thousand = n / 1000;
            int hundred = (n - 1000 * thousand) / 100;
            Console.WriteLine($"У числа {n} {thousand} тысяч {hundred} сотен");*/

            /*Console.WriteLine("Задание 24");
            int a = 1234;
            Console.WriteLine("Начальное число " + a);*/

            /*Console.WriteLine("Задание 24.1");
            int n1 = a % 10;
            int n2 = a % 100 - n1;
            int n3 = a % 1000 - n1 - n2;
            int n4 = (a % 10000 - n1 - n2 - n3) / 1000;
            int n = n1 * 1000 + n2 * 10 + n3 / 10 + n4;
            Console.WriteLine("Преобразованное число " + n);*/

            /*Console.WriteLine("Задание 24.2");
            int n1 = a % 10;
            int n2 = a % 100 - n1;
            int n3 = a % 1000 - n1 - n2;
            int n4 = (a % 10000 - n1 - n2 - n3) / 1000;
            int n = n3 * 10 + n4 * 100 + n1 * 10 + n2 / 10;
            Console.WriteLine("Преобразованное число " + n);*/

            /*Console.WriteLine("Задание 24.3");
            int n1 = a % 10;
            int n2 = a % 100 - n1;
            int n3 = a % 1000 - n1 - n2;
            int n4 = (a % 10000 - n1 - n2 - n3);
            int n = n4 + n2 * 10 + n3 / 10 + n1;
            Console.WriteLine("Преобразованное число " + n);*/

            /*Console.WriteLine("Задание 24.4");
            int n1 = a % 10;
            int n2 = a % 100 - n1;
            int n3 = a % 1000 - n1 - n2;
            int n4 = (a % 10000 - n1 - n2 - n3) / 1000;
            int n = n2 * 100 + n1 * 100 + n4 * 10 + n3 / 100;
            Console.WriteLine("Преобразованное число " + n);*/

            /*Console.WriteLine("Задание 25");
            int n = 312;
            Console.WriteLine("Преобразованное число " + n);
            int n1 = n / 100;
            int n2 = n - n1 * 100;
            int x = n2 * 10 + n1;
            Console.WriteLine("Начальное число " + x);*/

            /*Console.WriteLine("Задание 26");
            int h = 6;
            int m = 0;
            int s = 0;
            double angle = h * 30 + m * 0.5 + s / 120;
            if (angle > 360 | angle == 360)
            {
                angle -= 360;
            }
            Console.WriteLine($"Угол между положением часовой стрелки в начале суток и в указанный момент времени равен {angle} градусов ") ;*/

            /*Console.WriteLine("Задание 27");
            double y = 2; // 0<=y<=2, значения в радианах?
            double clockwise = 57.3 * y;
            int h = Convert.ToInt16(Math.Truncate(clockwise / 30));
            double m1 = clockwise - h * 30;
            double m2 = m1 * 2;
            double m3 = m2 * 6;
            int m = Convert.ToInt32(m2);
            Console.WriteLine($"Значение угла для минутной стрелки {m3} градусов, полных часов {h}, полных минут {m} ");*/

            /*Console.WriteLine("Задание 28");
            Console.Write("Введите первое число ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число ");
            double n3 = Convert.ToDouble(Console.ReadLine());
            if ( (Math.Abs (n1) < Math.Abs(n2)) && (Math.Abs(n1) < Math.Abs(n3)))
            {
                Console.WriteLine($"Меньшее по модулю из {n1}, {n2} и {n3} это {n1}");
            }
            if ((Math.Abs(n2) < Math.Abs(n1)) && (Math.Abs(n2) < Math.Abs(n3)))
            {
                Console.WriteLine($"Меньшее по модулю из {n1}, {n2} и {n3} это {n2}");
            }
            if ((Math.Abs(n3) < Math.Abs(n1)) && (Math.Abs(n3) < Math.Abs(n2)))
            {
                Console.WriteLine($"Меньшее по модулю из {n1}, {n2} и {n3} это {n3}");
            }
            */

            /*Console.WriteLine("Задание 29");
            int a = 2;
            int b = 13;
            int c = -4;
            int max = -100;
            int min = 100;
            if (a > max )
            { max = a; }
            if (b >max)
            { max = b; }
            if (c > max)
            { max = c; }
            if (a < min)
            { min = a; }
            if (b < min)
            { min = b; }
            if (c < min)
            { min = c; }

            Console.WriteLine("сумму большего и меньшего из трёх заданных чисел " + (max+min));*/

            /*Console.WriteLine("Задание 30");
            int n = 46889;
            int j = 0;
            for (int i = 1; i < n+1; i++)
            {
                if (n % i == 0)
                {
                    j++;
                }
            }
            Console.WriteLine($"У числа {n} {j} делителей ");*/
            
            /*Console.WriteLine("Задание 31");
            Console.Write("Введите а ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите d ");
            double d = Convert.ToDouble(Console.ReadLine());
            for (int x = -100; x < 101; x++)
            {
                if ( a*x*x*x + b*x*x + c*x + d == 0)
                {
                    Console.Write("Корень уравнения = " + x);  
                    Console.WriteLine();
                }
            }
            */

            /*Console.WriteLine("Задание 32");
            int a1 = 2;
            int a2 = 4;
            int d = a2 - a1;
            Console.Write("Введите порядковый номер члена ");
            int n = Convert.ToInt32(Console.ReadLine());
            int an= a1 + d*(n -1);
            Console.WriteLine($"а{n} = {an}");*/

            /*Console.WriteLine("Задание 33");
            Console.Write("Вы пенсионер и студент? (да/нет) ");
            string not = Console.ReadLine();
            if (not == "нет")
            {
                Console.Write("Введите свой статус: пенсионер(введите п), студент(введите с), работающий(введите р), бомж(введите б), неработающий(введите н) ");
                string status = Console.ReadLine();
                Console.Write("Вы трудоустроены? (да/нет) ");
                string working = Console.ReadLine();

                switch (status)
                {
                    case "п": {
                                if (working == "да")
                                 {
                                   Console.WriteLine("НЕ видать вам кредита!");
                                 }
                                else
                                 {
                                  Console.WriteLine("Поздравляем!!! Вы можете получить кредит!!!");
                                 }

                              } break;
                    case "с":
                        {
                            if (working == "да")
                            {
                                Console.WriteLine("НЕ видать вам кредита!");
                            }
                            else
                            {
                                Console.WriteLine("Поздравляем!!! Вы можете получить кредит!!!");
                            }

                        }
                        break;
                    case "р":Console.WriteLine("НЕ видать вам кредита!");break;
                    case "б":
                        {
                            if (working == "да")
                            {
                                Console.WriteLine("НЕ видать вам кредита!");
                            }
                            else
                            {
                                Console.WriteLine("Поздравляем!!! Вы можете получить кредит!!!");
                            }

                        }
                        break;
                    case "н":  Console.WriteLine("Поздравляем!!! Вы можете получить кредит!!!");
                        break;

                }
            }
            else
            {
                Console.WriteLine("НЕ видать вам кредита!");
            }
            */ 

            /*Console.WriteLine("Задание 34.1");
            Console.Write("Введите имя ");
            Console.Write(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Задание 34.2");
            Console.Write("Введите имя ");
            Console.Write("Здравствуйте, " + Console.ReadLine());*/

            //Console.WriteLine("Задание 35");


            /*Console.WriteLine("Задание 36");*/
        }
    }
}