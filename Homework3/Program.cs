using System;

// Молоствов Игорь
namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fractionA = new Fraction(1, 2);
            Fraction fractionB = new Fraction(-1, 2);


            Console.WriteLine($"Сумма: {Fraction.Sum(fractionA, fractionB).GetFraction()}");
            Console.WriteLine($"Разность: {Fraction.Diff(fractionA, fractionB).GetFraction()}");
            Console.WriteLine($"Умножение: {Fraction.Multiplication(fractionA, fractionB).GetFraction()}");
            Console.WriteLine($"Деление: {Fraction.Division(fractionA, fractionB).GetFraction()}");

            GetSum();
        }
        
        /*С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
         Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.*/
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
            } while (num != 0) ;
            return sum;
        }
    }
}