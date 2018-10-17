using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibr;

namespace _1._1._11
{
    class Program
    {

        public static void Main(string[] args)
        {
            Linear_Array arr = new Linear_Array();
            Input(arr);
            Select(arr);
        }

        public static void Input(Linear_Array arr)
        {
            Console.WriteLine("Введите размер массива");
            int length = Convert.ToInt32(Console.ReadLine());

            arr.Create(length);
            for (int i = 0; i < length; i++)
            {
                Console.Write("Введите {0} элемент массива - ", i + 1, "/n");
                arr.Arr[i] = new Element(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("МАССИВ: " + arr.Print());
        }

        public static void Select(Linear_Array arr)
        {
            int var = 0;
            Console.WriteLine("Переменная");
            var = Convert.ToInt32(Console.ReadLine());
            int key = 1;
            while (key != 0)
            {
                Console.WriteLine("Выберете необходимое дейсвие: \nНайти сумму - 1\nНайти разность - 2\nНайти произведение - 3\nДля выхода - 0");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        arr.Addition(var);
                        Console.WriteLine("СУММА = {0}", arr.Print());
                        break;
                    case 2:
                        arr.Difference(var);
                        Console.WriteLine("РАЗНОСТЬ = {0}", arr.Print());
                        break;
                    case 3:
                        arr.ProductOfNumbers(var);
                        Console.WriteLine("ПРОИЗВЕДЕНИЕ = {0}", arr.Print());
                        break;
                }
            }
        }
    }
}
