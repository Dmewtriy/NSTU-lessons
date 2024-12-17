using System;

namespace program_lab2
{
    // Класс Персона
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Нельзя установить пустую строку");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Нельзя установить значение меньшее нуля");
                }
                else
                {
                    age = value;
                }
            }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Person: {Name}, Age: {Age}";
        }
    }
}
