using lab1;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<off_tech> devices = new List<off_tech>();

        while (true)
        {
            Console.WriteLine("Ваш выбор:");
            Console.WriteLine("1 - Ввод техники");
            Console.WriteLine("2 - Ввод принтера");
            Console.WriteLine("3 - Ввод факса");
            Console.WriteLine("4 - Вывод всех устройств");
            Console.WriteLine("0 - Выход");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("\nВведите фирму: ");
                        string str = Console.ReadLine();
                        Console.WriteLine("Введите цену: ");
                        int price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите вес: ");
                        int weight = int.Parse(Console.ReadLine());

                        off_tech off = new off_tech(str, weight, price);
                        devices.Add(off);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nВведите фирму: ");
                        string str = Console.ReadLine();
                        Console.WriteLine("Введите цену: ");
                        int price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите вес: ");
                        int weight = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите скорость печати: ");
                        int speed = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите технологию печати: 1 - Laser, 2 - Light, 3 - Jet: ");
                        int sv3 = int.Parse(Console.ReadLine());
                        tech_of_print sv4 = (tech_of_print)sv3;

                        Printer printer = new Printer(speed, sv4, str, weight, price);
                        devices.Add(printer);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\nВведите фирму: ");
                        string str = Console.ReadLine();
                        Console.WriteLine("Введите цену: ");
                        int price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите вес: ");
                        int weight = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите разрешение страницы: ");
                        int resOfPages = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите наличие отложенной печати: 0 или 1 ");
                        bool delayedPrint = int.Parse(Console.ReadLine()) == 1;

                        var fax = new Fax(resOfPages, delayedPrint, str, weight, price);
                        devices.Add(fax);
                        break;
                    }
                case 4:
                    {
                        foreach (off_tech item in devices)
                        {
                            item.print();
                        }
                        break;
                    }
                case 0:
                    Console.WriteLine("Завершение работы");
                    return;
                default:
                    Console.WriteLine("\nНеверный выбор\n");
                    break;
            }
        }
    }
}