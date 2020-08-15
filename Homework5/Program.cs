using System;
using System.Text.RegularExpressions;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text =
                "Разработать статический класс Message содержащий следующие статические методы для обработки текста " +
                "а Вывести только те слова сообщения  которые содержат не более n букв " +
                "б Удалить из сообщения все слова которые заканчиваются на заданный символ " +
                "в Найти самое длинное слово сообщения " +
                "г Сформировать строку с помощью StringBuilder из самых длинных слов сообщения";
            
            Message.WordsByLength(text, 3);
            Message.DeleteWordsByLastChar(text, 'я');
            Message.FindLongestWord(text);
            ValidateLogin();
        }
        
        //Создать программу, которая будет проверять корректность ввода логина.
        static void ValidateLogin()
        {
            while (true)
            {
                Console.WriteLine("Введите логин:");
                string input = Console.ReadLine();
                Regex regex = new Regex("^([A-Za-z]{1}[A-Za-z0-9]{1,}$)");
                if (input != null && regex.IsMatch(input))
                {
                    Console.WriteLine("Вы вошли!");
                    break;
                }
                Console.WriteLine("Допустимый ввод: строка от 2 до 10 символов," +
                                  " содержащая только буквы латинского алфавита или цифры," +
                                  " при этом цифра не может быть первой");
                Console.WriteLine("Попробуйте ещё раз");
            }
        }
    }
}