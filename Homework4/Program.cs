using System;
using System.Linq;
// Молоствов Игорь
namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(10, 0, 5);
            Console.WriteLine(array.Sum);
            Console.WriteLine(array.MaxCount);
            array.Inverse().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
            array.Multy(2);
            array.Arr.ToList().ForEach(i => Console.Write(i + " ") );
            Console.WriteLine();
            Account account = new Account("C:\\Users\\Igor\\RiderProjects\\Homework\\Homework4\\data.txt");
            account.Authorize();
        }
    }
}