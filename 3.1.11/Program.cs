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
            List<ITextile> textileList = new List<ITextile>();
            ChooseClothesType(textileList);
        }

        static void ChooseClothesType(List<ITextile> textileList)
        {
            int checker = 1;
            while (checker != 0)
            {
                Console.WriteLine("Выберите тип изделия: \n0 - выход\n1 - Костюм");
                checker = CheckInput("", "Выберите значение из предложенного списка");
                switch (checker)
                {
                    case 0:
                        break;
                    case 1:
                        int countTextile = CheckInput("Введите количетво изделий: ", "Введите число!");
                        for (int i = 0; i < countTextile; i++)
                        {
                            string textileType = "";
                            string costumeName = "";
                            string manufacturerName = "";
                            int costumeIntegrity;
                            Console.WriteLine("Введите тип ткани: ");
                            textileType = Console.ReadLine();
                            Console.WriteLine("Введите название костюма: ");
                            costumeName = Console.ReadLine();
                            Console.WriteLine("Введите название производителя: ");
                            manufacturerName = Console.ReadLine();
                            costumeIntegrity = CheckInput("Цела ли ткань?\n0 - порвана\nЛюбое другое число - цела\n", "Введите число!");
                            textileList.Add(new Costume(manufacturerName, textileType, costumeName, Convert.ToBoolean(costumeIntegrity)));
                            Console.WriteLine("--------------------------------------------------------------------------");
                            Choose(textileList);
                        }
                        break;
                }
            }
        }

        static void Choose(List<ITextile> textileList)
        {
            int checker = 1;
            while (checker != 0)
            {
                Console.WriteLine("Выберите действие: \n0 - выход\n1 - отобразить список всех костюмов\n2 - выбрать костюм для работы");
                checker = CheckInput("", "Выберите значение из предложенного списка");
                switch (checker)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("--------------------------------------------------------------------------");
                        int counter = 0;
                        foreach (Costume costume in textileList)
                        {
                            counter++;
                            Console.WriteLine("#" + counter + "\n" + costume.CostumeName + "\n" + costume.TextileType + "\n" + costume.ManufacturerName);
                            Console.WriteLine("--------------------------------------------------------------------------");
                        }
                        break;
                    case 2:
                        int number = 0;
                        number = CheckInput("Выберите костюм\n", "Выберите номер из списка!");
                        if ((number < 0) || (number > textileList.Count()))
                        {
                            Console.WriteLine("Номер за пределами списка костюмов");
                        }
                        else
                        {
                            WorkWithTextile(textileList[number - 1]);
                        }
                        break;
                }
            }
        }

        static void WorkWithTextile(ITextile textile)
        {
            int checker = 1;
            while (checker != 0)
            {
                Console.WriteLine("Выберите действие: \n0 - выход\n1 - отобразить информацию о костюме\n2 - проверить целостность");
                checker = CheckInput("", "Выберите значение из предложенного списка");
                switch (checker)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine(textile.DisplayInformation());
                        Console.WriteLine("--------------------------------------------------------------------------");
                        break;
                    case 2:
                        textile.CheckIntegrity();
                        Console.WriteLine("Целостность проверена!");
                        break;
                }
            }
        }

        static int CheckInput(string text, string errorText)
        {
            Console.Write(text);
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine(errorText);
                Console.Write(text);
            }
            return value;
        }
    }
}
