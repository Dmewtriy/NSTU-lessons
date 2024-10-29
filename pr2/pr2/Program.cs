using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class Program
    {
        public static void firstTask()
        {
            int n;
            Console.Write("Введите размер массива N: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++) array[i] = i + 1;
            for (int i = n - 1; i >= 0; i--) Console.WriteLine(array[i]);
            Console.Read();
        }

        public static void secondTask() 
        {
            int n;
            Console.Write("Введите размер массива NxN: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n,n];
            int k = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = k; j < n; j++)
                {
                    array[i,j] = 1;
                    array[i + 1, j] = 1;
                }
                k++;
            }
            for (int i = 0; i < n; i++)
            {
                for(int j  = 0; j < n; j++) Console.Write(array[i,j] + " ");
                Console.WriteLine();
            }
            Console.Read();
        }
        
        public static void thirdTask()
        {
            int n;
            Console.Write("Введите размер массива NxN: ");
            n = Convert.ToInt32(Console.ReadLine());
            int value = 1;
            int[,] array = new int[n, n];

            int minRow = 0, maxRow = n - 1;
            int minCol = 0, maxCol = n - 1;

            while (value <= n * n)
            {
                // Заполняем верхнюю строку слева направо
                for (int i = minCol; i <= maxCol; i++)
                    array[minRow, i] = value++;
                minRow++;

                // Заполняем правый столбец сверху вниз
                for (int i = minRow; i <= maxRow; i++)
                    array[i, maxCol] = value++;
                maxCol--;

                // Заполняем нижнюю строку справа налево
                for (int i = maxCol; i >= minCol; i--)
                    array[maxRow, i] = value++;
                maxRow--;

                // Заполняем левый столбец снизу вверх
                for (int i = maxRow; i >= minRow; i--)
                    array[i, minCol] = value++;
                minCol++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(3) + " ");
                }
                Console.WriteLine();
            }
        }

        public static void fourthTask()
        {
            int n, m;
            Console.Write("Введите количесвто строк массива M: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количесвто строк массива N: ");
            n = Convert.ToInt32(Console.ReadLine());
            int value = 1;
            int[,] array = new int[m, n];

            int minRow = 0, maxRow = m - 1;
            int minCol = 0, maxCol = n - 1;

            while (value <= m * n)
            {
                // Заполняем верхнюю строку слева направо
                for (int i = minCol; i <= maxCol && value <= m * n; i++)
                    array[minRow, i] = value++;
                minRow++;

                // Заполняем правый столбец сверху вниз
                for (int i = minRow; i <= maxRow && value <= m * n; i++)
                    array[i, maxCol] = value++;
                maxCol--;

                // Заполняем нижнюю строку справа налево
                for (int i = maxCol; i >= minCol && value <= m * n; i--)
                    array[maxRow, i] = value++;
                maxRow--;

                // Заполняем левый столбец снизу вверх
                for (int i = maxRow; i >= minRow && value <= m * n; i--)
                    array[i, minCol] = value++;
                minCol++;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(3) + " ");
                }
                Console.WriteLine();
            }
        }

        enum Operations
        {
            division,
            powering,
            squareRoot
        }

        int DoOperation(Operations op, int a, int b)
        {
            switch (op) 
            {
                case Operations.division: return a / b;
                case Operations.powering: return (int)Math.Pow(a, b);
                case Operations.squareRoot: return (int)Math.Sqrt(a);
                default: return 0;
            }
        }

        static void Main(string[] args)
        {
            fourthTask();
        }
    }
}
