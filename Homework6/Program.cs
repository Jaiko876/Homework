using System;
//Молоствов Игорь
namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Choice();

        }
        /*Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
        а) Сделать меню с различными функциями и представить пользователю выбор, 
        для какой функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов,
         в котором хранятся различные функции.
        */
        static void Choice()
        {
            Console.WriteLine("Выберите функцию: 1 - a*x^2, 2 - a*sin(x)");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите начало отрезка:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец отрезка:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число a:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Table.TableFunc(Table.MyFunc, x, x1, a);
            }
            else if (input == 2)
            {
                Table.TableFunc(Table.MyAnotherFunc, x, x1, a);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
    }
}