//Молоствов Игорь
using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Минимальное: {FindMin(25, 24, 13)}");
            Console.WriteLine($"Количество цифр: {GetCountsOfDigits(242)}");
            Console.WriteLine($"Сумма положительных чисел: {GetSum()}");
            if (Authorize("root", "GeekBrains"))
                Console.WriteLine("Вы вошли");
        }

        //Написать метод, возвращающий минимальное из трёх чисел.

        private static int FindMin(int a, int b, int c)
        {
            int min;

            if (a < b)
            {
                min = a;
            }
            else
            {
                min = b;
            }

            if (min > c)
            {
                min = c;
            }

            return min;
        }

        // Написать метод подсчета количества цифр числа.
        private static int GetCountsOfDigits(long number)
        {
            int count = (number == 0) ? 1 : 0;
            while (number != 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }

        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        private static int GetSum()
        {
            String input;
            int num;
            int sum = 0;
            do
            {
                Console.WriteLine("Введите число: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out num))
                {
                    if (num > 0 && num % 2 == 0)
                        sum += num;
                }
                Console.WriteLine(sum);
            } while (num != 0) ;
            return sum;
        }

        // Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        //С помощью цикла do while ограничить ввод пароля тремя попытками.

        private static bool Authorize(String login, String password)
        {
            int counter = 0;
            String inputLogin;
            String inputPassword;
            do
            {
                Console.WriteLine("Введите логин: ");
                inputLogin = Console.ReadLine();
                if (login.Equals(inputLogin))
                {
                    Console.WriteLine("Введите пароль: ");
                    inputPassword = Console.ReadLine();
                    if (password.Equals(inputPassword))
                        return true;
                    else
                        Console.WriteLine($"Неверный пароль, осталось попыток: {2 - counter}");
                }
                else
                    Console.WriteLine($"Неверный логин, осталось попыток: {2 - counter}");
                counter++;
            } while (counter != 3);
            return false;
        }

    }
}
