using System;

// Молоствов Игорь
namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm();
            Bmi();
            DistanceBetweenPoints(0, 0, 5, 5);
            
        }

        // Анкета
        private static void MyForm()
        {
            Console.WriteLine("Введите ваше имя:\n");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:\n");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:\n");
            string age = Console.ReadLine();
            Console.WriteLine("Введите ваш рост:\n");
            string height = Console.ReadLine();
            Console.WriteLine("Введите ваш вес:\n");
            string weight = Console.ReadLine();

            Console.WriteLine("Имя:" + name + " Фамилия:" + surname + " Возраст:" + age + " Рост:" + height + " Вес:" + weight);
            Console.WriteLine("Имя:{0} Фамилия:{1} Возраст:{2} Рост:{3} Вес:{4}", name, surname, age, height, weight);
            Console.WriteLine($"Имя:{name} Фамилия:{surname} Возраст:{age} Рост:{height} Вес:{weight}");
        }

        // Индекс массы
        private static void Bmi()
        {
            double weight = 80;
            double height = 180;
            Console.WriteLine(weight / (height * height));
        }

        // Рассчёт расстояния между точками
        private static void DistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            Console.WriteLine("{0:f2}",Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }
    }
}
