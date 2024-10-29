using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Specialized;

namespace pr3
{
    internal class Program
    {
        public static void part1()
        {
            ArrayList arrayList = new ArrayList();
            Random rnd = new Random();
            for (int i = 0; i < 5; i++) { arrayList.Add(rnd.Next(0, 1000)); }
            arrayList.Add("Qwerty");

            arrayList.Remove("Qwerty");

            Console.WriteLine(arrayList.Count + "\n");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.Write("Введите значение для поиска: ");
            string myItem = Console.ReadLine();

            bool flag = false;

            foreach (var item in arrayList)
            {
                if (item.ToString() == myItem) { flag = true; break; }
            }

            if (flag) { Console.WriteLine($"Значение {myItem} найдено"); }
            else Console.WriteLine($"Значение {myItem} не найдено");
        }
        public static void part2() 
        {
            Stack<double> stack = new Stack<double>();
            Random rnd = new Random();
            for (int i = 0; i < 5; i++) { stack.Push(Math.Round(rnd.NextDouble() * 100, 3)); }

            foreach (var item in stack) Console.WriteLine(item.ToString());
            Console.WriteLine();
            int n = 3;
            for (int i = 0; i < n; i++) { stack.Pop(); }

            stack.Push(2.684);
            stack.Push(3.427);

            LinkedList<double> list = new LinkedList<double>();

            foreach (double number in stack)
            {
                list.AddLast(number);
            }

            foreach (double number in list)
            {
                Console.WriteLine(number.ToString());
            }

            Console.WriteLine($"Элемент {2.684} {(list.Contains(2.684) ? "найден" : "не найден")}" );
        }

        public static void part3()
        {
            Stack<off_tech> stack = new Stack<off_tech>();

            stack.Push(new off_tech("Lg", 2, 20000));
            stack.Push(new off_tech("Asus", 5, 15000));
            stack.Push(new off_tech("Samsung", 10, 1000));
            stack.Pop();
            stack.Push(new off_tech("Xerox", 12, 200000));

            LinkedList<off_tech> list = new LinkedList<off_tech>();

            foreach (off_tech number in stack)
            {
                off_tech a = (off_tech)number.Clone();
                list.AddLast(a);
            }

            off_tech[] stackToArray = stack.ToArray();
            off_tech[] listToArray = list.ToArray();

            Array.Sort(stackToArray);
            Array.Sort(listToArray, new off_techComparer());

            stackToArray[0].firm = "Apple";

            Console.WriteLine("\nStack:\n");
            foreach (var item in stackToArray)
            {
                item.print();
                Console.WriteLine();
            }

            Console.WriteLine("\nList:\n");
            foreach (var item in listToArray)
            {
                item.print();
                Console.WriteLine();
            }
        }

        public static void part4()
        {
            ObservableCollection<off_tech> coll = new ObservableCollection<off_tech>() {new off_tech("Asus", 3, 15000) };
            coll.CollectionChanged += NotifyCollectionChangedEventHandler;

            coll.Add(new off_tech("Lg", 15, 20000));
            coll.Add(new off_tech("Apple", 2, 100000));

            coll.RemoveAt(0);
            Console.WriteLine();
            Console.WriteLine("Список устройств:");
            foreach (var item in coll)
            {
                item.print();
                Console.WriteLine();
            }
        }

        public static void NotifyCollectionChangedEventHandler(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action) 
            {
                case NotifyCollectionChangedAction.Add:
                    if (e.NewItems?[0] is off_tech newTech)
                        Console.WriteLine($"Добавлен новый объект: {newTech.firm}");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    if (e.OldItems?[0] is off_tech oldTech)
                        Console.WriteLine($"Удалён объект {oldTech.firm}");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Часть 1\n");
            part1();
            Console.WriteLine();
            Console.WriteLine("Часть 2\n");
            part2();
            Console.WriteLine();
            Console.WriteLine("Часть 3\n");
            part3();
            Console.WriteLine();
            Console.WriteLine("Часть 4\n");
            part4();
        }
    }
}
