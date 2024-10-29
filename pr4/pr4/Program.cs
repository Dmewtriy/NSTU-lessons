using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    internal class Program
    {
        public static void part1()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            Console.Write("Введите длину месяцев для выбора n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            var monthsWithNLength = from m in months
                                    where m.Length == n
                                    select m;

            Console.WriteLine($"Последовательность месяцев с длинной {n}:");
            foreach (var month in monthsWithNLength)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine();

            var summerAndWintermonths = from m in months
                                        where m == "January" || m == "February" || m == "June" || m == "July" || m == "August" || m == "December"
                                        select m;

            Console.WriteLine("Последовательность летних и зимних месяцев:");
            foreach (var month in summerAndWintermonths)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine();

            var monthsInAlphabetOrder = from m in months
                                        orderby m
                                        select m;

            Console.WriteLine("Последовательность месяцев в алфавитном порядке:");
            foreach (var month in monthsInAlphabetOrder)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine();

            var monthsWithLetterUAndMinLength4 = from m in months
                                                 where m.Length >= 4 && m.Contains('u')
                                                 select m;

            Console.WriteLine("Последовательность месяцев содержащие букву «u» и длиной имени не менее 4-х.:");
            foreach (var month in monthsWithLetterUAndMinLength4)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine();
        }

        public static void part2()
        {
            List<Student> list = new List<Student>
            {
                new Student(),
                new Student("Данькин", "Дмитрий", "Витальевич", new DateTime(2005, 09, 23), 2, "АВТ-312"),
                new Student("Бикмухаметов", "Таир", "Олегович", new DateTime(2005, 09, 27), 2, "АВТ-312"),
                new Student("Манаенков", "Евгений", "Дмитриевич", new DateTime(2004, 11, 03), 2, "АВТ-312")
            };

            var lisOfStudentsInAGivenCourse = from student in list
                                              where student.Rate == 1
                                              select student;
            Console.WriteLine("Список студентов заданного курса(1):");
            foreach(var std in  lisOfStudentsInAGivenCourse)
            {
                Console.WriteLine(std);
            }
            Console.WriteLine();

            Student youngestStudent = (from student in list
                                   orderby student.DateOfBirthToDate
                                   select student).Last();
            Console.WriteLine($"Самый молодой студент - {youngestStudent}");
            Console.WriteLine();

            int numberOfStudentsInAGivenGroup = (from student in list
                                                where student.Group == "АВТ-312"
                                                select student).Count();
            Console.WriteLine($"Количество студентов заданной группы(АВТ-312) = {numberOfStudentsInAGivenGroup}");
            Console.WriteLine();


            Student firstStudentWithGivenName = (from student in list
                                                where student.FirstName == "Евгений"
                                                select student).First();
            Console.WriteLine($"Первый студент с заданным именем(Евгений) - {firstStudentWithGivenName}");
            Console.WriteLine();

            var listOfStudentsOrderedByLastname = from student in list
                                                  orderby student.LastName
                                                  select student;
            Console.WriteLine("Список студентов, упорядоченный по фамилии:");
            foreach (var student in listOfStudentsOrderedByLastname) { Console.WriteLine(student); }
        }
        static void Main()
        {
            part1();
            Console.WriteLine();
            part2();
            Console.ReadLine();
        }
    }
}
