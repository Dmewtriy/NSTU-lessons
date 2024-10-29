using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            int width = 80, height = 25;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(' ');
                }
            }
            Console.SetCursorPosition(0, 0);
            Console.SetWindowSize(width, height);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write("    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('Л');
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("евая");
            Console.Write("    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('Ф');
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("айл");
            Console.Write("    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('Д');
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("иск");
            Console.Write("    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('К');
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("оманды");
            Console.Write("    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('П');
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("равая");
            Console.Write("                             ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (date.Hour.ToString().Length == 1)
            {
                Console.Write($" {date.Hour} ");
                if (date.Minute < 10)
                    Console.WriteLine($"0{date.Minute}");
                else Console.WriteLine($"{date.Minute}");
            }
            else 
            {   
                Console.Write($"{date.Hour} ");
                if (date.Minute < 10)
                    Console.WriteLine($"0{date.Minute}");
                else Console.WriteLine($"{date.Minute}");
            }

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write('\u2554');
            for (int i = 0; i <12; i++) { Console.Write('\u2550'); }
            Console.Write('\u2564');
            for (int i = 0; i < 12; i++) { Console.Write('\u2550'); }
            Console.Write('\u2564');
            for (int i = 0; i < 12; i++) { Console.Write('\u2550'); }
            Console.Write('\u2557');
            Console.Write('\u2554');
            for (int i = 0; i < 12; i++) { Console.Write('\u2550'); }
            Console.Write('\u2564');
            for (int i = 0; i < 9; i++) { Console.Write('\u2550'); }
            Console.Write('\u2564');
            for (int i = 0; i < 8; i++) { Console.Write('\u2550'); }
            Console.Write('\u2564');
            for (int i = 0; i < 6; i++) { Console.Write('\u2550'); }
            Console.Write('\u2557');
            for (int i = 2; i < 20; i++) 
            { 
                Console.SetCursorPosition(0, i); 
                Console.Write('\u2551');
                Console.SetCursorPosition(13, i);
                Console.Write('\u2502');
                Console.SetCursorPosition(26, i);
                Console.Write('\u2502');
                Console.SetCursorPosition(39, i);
                Console.Write('\u2551');
                Console.SetCursorPosition(40, i);
                Console.Write('\u2551');
                Console.SetCursorPosition(53, i);
                Console.Write('\u2502');
                Console.SetCursorPosition(63, i);
                Console.Write('\u2502');
                Console.SetCursorPosition(72, i);
                Console.Write('\u2502');
                Console.SetCursorPosition(79, i);
                Console.Write('\u2551');
            }
            Console.SetCursorPosition(0, 20);
            Console.Write('\u255f');
            for(int i =0; i < 12; i++) { Console.Write('\u2500'); }
            Console.Write('\u2534');
            for (int i = 0; i < 12; i++) { Console.Write('\u2500'); }
            Console.Write('\u2534');
            for (int i = 0; i < 12; i++) { Console.Write('\u2500'); }
            Console.Write('\u2562');

            Console.Write('\u255f');
            for (int i = 0; i < 12; i++) { Console.Write('\u2500'); }
            Console.Write('\u2534');
            for (int i = 0; i < 9; i++) { Console.Write('\u2500'); }
            Console.Write('\u2534');
            for (int i = 0; i < 8; i++) { Console.Write('\u2500'); }
            Console.Write('\u2534');
            for (int i = 0; i < 6; i++) { Console.Write('\u2500'); }
            Console.Write('\u2562');

            Console.SetCursorPosition(0, 21);
            Console.Write('\u2551');
            Console.SetCursorPosition(39, 21);
            Console.Write('\u2551');
            Console.SetCursorPosition(40, 21);
            Console.Write('\u2551');
            Console.SetCursorPosition(79, 21);
            Console.WriteLine('\u2551');

            Console.Write('\u255A');
            for (int i = 0; i < 38; i++) { Console.Write('\u2550'); }
            Console.Write("\u255d\u255A");

            for (int i = 0; i < 38; i++) { Console.Write('\u2550'); }
            Console.WriteLine('\u255d');

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("C:\\NC>");
            string[] words = { "Помощь", "Вызов ","Чтение","Правка", "Копия ", "НовИмя", "НовКат", "Удал-е", "Меню  ", "Выход " }; 
            for(int i = 0; i < 10; i++)
            {
                Console.Write((i+1).ToString());
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($"{words[i]}");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(' ');
            }

            List<File> Files = new List<File>();
            string[] files = Directory.GetFiles(@"C:\Users\дмитрий\Desktop");
             foreach (string fileName in files)
            {
                FileInfo fileInfo = new FileInfo(fileName);
                string[] nameAndExtension = fileInfo.Name.Split('.');
                string name = nameAndExtension[0];
                string extension = nameAndExtension[1];
                if (name.Length < 8) {}
                else if (name.Length >= 8) { name = name.Remove(7); name += '~'; }
                string size = (fileInfo.Length > 10000000) ? fileInfo.Length.ToString().Remove(8) + '~' : fileInfo.Length.ToString();
                string[] lastWriteTime = fileInfo.LastWriteTime.ToString().Split(' ');
                string dateOfChange = lastWriteTime[0];
                dateOfChange = dateOfChange.Remove(6, 2);
                string timeOfChange = lastWriteTime[1];
                timeOfChange = timeOfChange.Remove(timeOfChange.Length - 3, 3);
                File newFile = new File(name, extension, size, dateOfChange, timeOfChange);
                Files.Add(newFile);
            }
            Files.Sort();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < Files.Count; i++)
            {
                if (i < 17) Console.SetCursorPosition(1, i + 3);
                else if (i >= 34 && i < 51) { i -= 34; Console.SetCursorPosition(27, i + 3); i += 34; }
                else if (i >= 17 && i < 34) { i -= 17; Console.SetCursorPosition(14, i + 3); i += 17; }
                else break;
                Console.Write(Files[i].name);
                if (Files[i].extension.Length == 3)
                {
                    if (i < 17) Console.SetCursorPosition(10, i + 3);
                    else if (i >= 34 && i < 51) { i -= 34; Console.SetCursorPosition(36, i + 3); i += 34; }
                    else if (i >= 17 && i < 34) { i -= 17; Console.SetCursorPosition(23, i + 3); i += 17; }
                    else break;
                    Console.Write(Files[i].extension);
                }
                else if (Files[i].extension.Length == 2)
                {
                    if (i < 17) Console.SetCursorPosition(11, i + 3);
                    else if (i >= 34 && i < 51) { i -= 34; Console.SetCursorPosition(37, i + 3); i += 34; }
                    else if (i >= 17 && i < 34) { i -= 17; Console.SetCursorPosition(24, i + 3); i += 17; }
                    else break;
                    Console.Write(Files[i].extension);
                }
                else
                {
                    if (i < 17) Console.SetCursorPosition(10, i + 3);
                    else if (i >= 34 && i < 51) { i -= 34; Console.SetCursorPosition(36, i + 3); i += 34; }
                    else if (i >= 17 && i < 34) { i -= 17; Console.SetCursorPosition(23, i + 3); i += 17; }
                    else break;
                    Console.Write(Files[i].extension.ToString().Remove(3));
                }
            }

            for (int i = 0; i < 17; i++)
            {
                Console.SetCursorPosition(41, i + 3);
                Console.Write(Files[i].name);
                Console.SetCursorPosition(63 - Files[i].size.Length, i + 3);
                Console.Write(Files[i].size);
                Console.SetCursorPosition(64, i + 3);
                Console.Write(Files[i].dateOfChange);
                Console.SetCursorPosition(79 - Files[i].timeOfChange.Length, i + 3);
                Console.Write(Files[i].timeOfChange);
                if (Files[i].extension.Length == 3)
                {
                    Console.SetCursorPosition(50, i + 3);
                    Console.Write(Files[i].extension);
                }
                else if (Files[i].extension.Length == 2)
                {
                    Console.SetCursorPosition(51, i + 3);
                    Console.Write(Files[i].extension);
                }
                else
                {
                    Console.SetCursorPosition(50, i + 3);
                    Console.Write(Files[i].extension.ToString().Remove(3));
                }
            }

            Console.SetCursorPosition(1, 2);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("C:\u2193 Имя");
            Console.SetCursorPosition(18, 2);
            Console.Write("Имя");
            Console.SetCursorPosition(31, 2);
            Console.Write("Имя");
            Console.SetCursorPosition(41, 2);
            Console.Write("C:↓ Имя");
            Console.SetCursorPosition(56, 2);
            Console.Write("Размер");
            Console.SetCursorPosition(66, 2);
            Console.Write("Дата");
            Console.SetCursorPosition(73, 2);
            Console.Write("Время");

            Console.SetCursorPosition(1, 21);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("..           ►КАТАЛОГ◄ 11.10.02  19:48");
            Console.SetCursorPosition(41, 21);
            Console.Write("..           ►КАТАЛОГ◄ 11.10.02  19:48");

            Console.SetCursorPosition(16, 1);
            Console.Write(" C:\\NC ");
            Console.SetCursorPosition(56, 1);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" C:\\NC ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(6, 23);
            Console.ReadLine();
        }
    }
}
