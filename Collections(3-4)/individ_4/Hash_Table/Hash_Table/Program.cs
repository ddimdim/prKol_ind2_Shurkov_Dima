using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog1 = new Catalog();
            while (true)
            {
                Console.WriteLine("Введите действие: ");
                Console.WriteLine("- Добавить диск");
                Console.WriteLine("- Удалить диск");
                Console.WriteLine("- Добавить песню");
                Console.WriteLine("- Удалить песню");
                Console.WriteLine("- Вывести каталог");
                Console.WriteLine("- Поиск песен");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "Добавить диск":
                        catalog1.Add_Disk();
                        break;
                    case "Удалить диск":
                        catalog1.Remove_Disk();
                        break;
                    case "Добавить песню":
                        catalog1.Add_Song();
                        break;
                    case "Удалить песню":
                        catalog1.Remove_Song();
                        break;
                    case "Вывести каталог":
                        catalog1.Print();
                        break;
                    case "Поиск песен":
                        catalog1.Search();
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }
    }
}
