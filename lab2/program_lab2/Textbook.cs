using System;

namespace program_lab2
{
    // Класс Учебник (бесплодный класс)
    public sealed class Textbook : PrintedEdition
    {
        public string Subject { get; }

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
