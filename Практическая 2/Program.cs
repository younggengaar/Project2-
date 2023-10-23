using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания:");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("меняет знак у переменной х на противоположный и выполняет умножение на вещественное число y");
                        Console.Write("x=");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("y=");
                        double y = Convert.ToDouble(Console.ReadLine());
                        x = -x;
                        Console.WriteLine($"-x={x}");
                        Console.WriteLine($"-x*y={x * y}");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Дано четырехзначное число. Найти число, полученное при прочтении его цифр справа налево");
                        Console.Write("Введите четырехзначное число=");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int a = (x / 1000);
                        int b = (x % 1000 / 100);
                        int c = (x % 100 / 10);
                        int d = (x % 10);
                        Console.WriteLine($"Результат:{d}{c}{b}{a}");
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Найти радиус окружности, вписанной в равносторонний треугольник со стороной а");
                        Console.Write("Введите сторону а=");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"R={a / 2 * (Math.Sqrt(3))}");
                        Console.ReadKey();
                    }
                    break;
                default :
                    {
                        Console.Write("Такого задания нет");
                    }
                    break;
            }
        }
    }
    
}
