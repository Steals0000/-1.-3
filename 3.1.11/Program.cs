using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibr._3._1._11;

namespace _3._1._11
{
    public class Program
    {
        static void Main(string[] args)
        {
            string textileType = "";
            string costumeName = "";
            string manufacturerName = "";
            int isIntegrityChecked;
            int countCotumes = InputCheck("Введите количетво костюмов: ");
            List<ITextile> costumesList = new List<ITextile>();
            for (int i = 0; i < countCotumes; i++)
            {
                Console.WriteLine("Введите тип ткани: ");
                textileType = Console.ReadLine();
                Console.WriteLine("Введите название костюма: ");
                costumeName = Console.ReadLine();
                Console.WriteLine("Введите название производителя: ");
                manufacturerName = Console.ReadLine();
                isIntegrityChecked = InputCheck("Цела ли ткань?\n0 - порвана\nЛюбое другое число - цела\n");
                costumesList.Add(new Costume(Convert.ToBoolean(isIntegrityChecked), manufacturerName, textileType, costumeName));
                Console.WriteLine("--------------------------------------------------------------------------");
            }
            Choose(costumesList);
        }

        static void Choose(List<ITextile> costumesList)
        {
            int checker = 1;
            while (checker != 0)
            {
                Console.WriteLine("Выберите действие: \n0 - выход\n1 - отобразить список всех костюмов\n2 - выбрать костюм для работы");
                while (!int.TryParse(Console.ReadLine(), out checker))
                {
                    Console.WriteLine("Выберите значение из предложенного списка\n");
                }

                switch (checker)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("--------------------------------------------------------------------------");
                        int counter = 0;
                        foreach (Costume costume in costumesList)
                        {
                            counter++;
                            Console.WriteLine("#" + counter + "\n" + costume.CostumeName + "\n" + costume.TextileType + "\n" + costume.ManufacturerName);
                            Console.WriteLine("--------------------------------------------------------------------------");
                        }
                        break;
                    case 2:
                        int number = 0;
                        Console.WriteLine("Выберите костюм");
                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.WriteLine("Выберите номер из списка!");
                        }
                        if ((number < 0) || (number > costumesList.Count()))
                        {
                            Console.WriteLine("Номер за пределами списка костюмов");
                        }
                        else
                        {
                            WorkWithCostume(costumesList[number - 1]);
                        }
                        break;
                }
            }
        }

        static void WorkWithCostume(ITextile costume)
        {
            int checker = 1;
            while (checker != 0)
            {
                Console.WriteLine("Выберите действие: \n0 - выход\n1 - отобразить информацию о костюме\n2 - отметить костюм как целый\n3 - написать отзыв\n4 - отметить костюм как хороший\n5 - отметить костюм как плохой");
                while (!int.TryParse(Console.ReadLine(), out checker))
                {
                    Console.WriteLine("Выберите значение из предложенного списка");
                }

                switch (checker)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine(costume.DisplayInformation());
                        Console.WriteLine("--------------------------------------------------------------------------");
                        break;
                    case 2:
                        ((Costume)costume).CheckIntegrity();
                        Console.WriteLine("Костюм цел");
                        break;
                    case 3:
                        Console.WriteLine("Введите свой отзыв");
                        ((Costume)costume).WriteAReview(Console.ReadLine());
                        Console.WriteLine("Oтзыв оставлен");
                        break;
                    case 4:
                        if (((Costume)costume).MarkAsGood())
                        {
                            Console.WriteLine("Костюм отмечен как хороший");
                        }
                        else
                        {
                            Console.WriteLine("Вы не можете отметить костюм как хороший, не проверив его на целостность");
                        }
                        break;
                    case 5:
                        ((Costume)costume).MarkAsBad();
                        Console.WriteLine("Костюм отмечен как плохой");
                        break;
                }
            }
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
