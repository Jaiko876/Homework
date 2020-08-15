using System;

namespace Homework6
{    /*Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
 Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).*/
    public class Table
    {
        public delegate double Fun(double a, double x);

        public static void TableFunc(Fun f, double a, double x, double k)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (a <= x)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", a, f(k, a));
                a += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyAnotherFunc(double a, double x)
        {
            return a * Math.Sin(x);
        }
        
        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

    }
}