using System;
using System.IO;

// Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
namespace Homework4
{
    public class Account
    {
        private string login;
        private string password;
        private string dataPath;
        private int attempts;

        public Account(string path)
        {
            this.dataPath = path;
            attempts = 3;
        }

        public bool Authorize()
        {
            int counter = 0;
            StreamReader sr = new StreamReader(dataPath);
            while (!sr.EndOfStream)
            {
                string temp = sr.ReadLine();
                if (temp == null)
                    continue;
                if (counter % 2 == 0)
                {
                    login = temp.Trim();
                }
                else
                {
                    password = temp.Trim();
                }

                if (login != null && password != null)
                {
                    if (Authorize(login, password))
                    {
                        sr.Close();
                        return true;
                    }

                    login = null;
                    password = null;
                }

                counter++;
            }
            sr.Close();
            return false;
        }
        
        private bool Authorize(string login, string password)
        {
            if (attempts != 0)
            {
                if (!login.Equals("root"))
                {
                    Console.WriteLine($"Неверный логин, осталось попыток: {--attempts}");
                    return false;
                }

                if (login.Equals("root") && !password.Equals("GeekBrains"))
                {
                    Console.WriteLine($"Неверный пароль, осталось попыток: {--attempts}");
                    return false;
                }

                Console.WriteLine("Вы вошли!");
                return true;
            }
            Console.WriteLine("Вы израсходовали все попытки на вход");
            return false;
        }
    }
}