using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Вычислить квадратное уравнение.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //try
            //{
            //    Console.Write("a = ");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.Write("b = ");
            //    int b = int.Parse(Console.ReadLine());
            //    Console.Write("c = ");
            //    int c = int.Parse(Console.ReadLine());
            //    double d = Math.Pow(b, 2) - 4 * a * c;
            //    if(d > 0)
            //    {
            //        Console.WriteLine("2 корня");
            //        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            //        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            //        Console.WriteLine($"x1 = {x1:N2}\tx2={x2:N2}");
            //    }
            //    if(d == 0)
            //    {
            //        Console.WriteLine("1 корень");
            //        double x = -b / (2 * a);
            //        Console.WriteLine($"x = {x:N2}");
            //    }
            //    if(d < 0)
            //    {
            //        Console.WriteLine("Нет корней");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Исключение: {ex.Message}");
            //    Console.WriteLine($"Метод: {ex.TargetSite}");
            //    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            //}

            //Задача 2
            //Console.Write("a = ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b = ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("c = ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //if(a + b > c && a + c > b && c + b > a)
            //{
            //    Console.WriteLine("Такой треугольник существует");
            //    double p = (a + b + c) / 2.0;
            //    double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //    Console.WriteLine($"Площадь треугольника: {s:N2}");
            //}
            //else
            //{
            //    Console.WriteLine("Такого треугольника не существует");
            //}
        }
    }
}
