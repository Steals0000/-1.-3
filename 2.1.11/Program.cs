using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibr._2._1._11;

namespace _2._1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Performance performance;
            Console.Write("Введите название спектакля: ");
            string name = Console.ReadLine();
            int startViewersCount = InputCheck("Введите начальное количество зрителей: ");
            int endViewersCount = InputCheck("Введите конечное количество зрителей: ");
            performance = new Performance(startViewersCount, endViewersCount, name);
            Console.WriteLine("Спектакль " + performance.Name + " создан");
            Console.WriteLine("Качество спектакля - " + performance.GetQuality());
            Console.Write("\nВведите название второго спектакля: ");
            name = Console.ReadLine();
            startViewersCount = InputCheck("Введите начальное количество зрителей: ");
            endViewersCount = InputCheck("Введите конечное количество зрителей: ");
            int yearOfWriting = InputCheck("Введите год написания спектакля: ");
            performance = new PerformanceChild(startViewersCount, endViewersCount, name, yearOfWriting);
            Console.WriteLine("Качество спектакля - " + performance.GetQuality());
            Console.ReadKey();
        }

        static int InputCheck(string text)
        {
            Console.Write(text);
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Пожалуйста, введите число!");
                Console.Write(text);
            }
            return value;
        }
    }
}
