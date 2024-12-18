using System;
using System.Xml.Linq;

namespace program_lab2
{
    // Класс Учебник (бесплодный класс)
    public sealed class Textbook : PrintedEdition
    {
        private string subject;
        public string Subject
        {
            get { return subject; }
            private set
            {
                 if (string.IsNullOrEmpty(value))
                 {
                    throw new ArgumentException("Название предмета не может быть пустым или состоять из пробелов.");
                 }       
                subject = value;
            }   
        }

        public Textbook(string Title, int Year, Author Author, Publishing Publishing, string Subject) : base(Title, Year, Author, Publishing)
        {
            this.Subject = Subject;
        }


        public override void Read()
        {
            Console.WriteLine($"I reading a {Subject} textbook");
        }

        public override string ToString()
        {
            return base.ToString() + $", Subject: {Subject}";
        }
    }
}
