using System;

namespace program_lab2
{
    // Класс Издательство
    public class Publishing
    {
        private string name;
        private string address;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Имя не может быть пустым или состоять из пробелов.");
                }
                name = value;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Адрес не может быть пустым или состоять из пробелов.");
                }
                address = value;
            }
        }
        public Publishing(string name, string address) 
        { 
            Name = name;
            Address = address;  
        }
        public override string ToString()
        {
            return $"Publishing: {Name}, Address: {Address}";
        }
    }
}
