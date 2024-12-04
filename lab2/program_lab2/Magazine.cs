using System;

namespace program_lab2
{
    // Класс Журнал
    public class Magazine : PrintedEdition
    {
        private string topic;
        public string Topic
        {
            get
            {
                return topic;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Атрибут topic. Пустая строка");
                }
                else
                {
                    topic = value;
                }
            }

        }

        public Magazine(string title, int year, Publishing publishingHouse, string topic)
        : base(title, year, null, publishingHouse) // У журналов может не быть автора
        {
            Topic = topic;
        }
        public Magazine(string title, int year, Author author, Publishing publishingHouse, string topic)
        : base(title, year, author, publishingHouse)
        {
            Topic = topic;
        }
        public override void Read()
        {
            Console.WriteLine($"I reading a magazine about {Topic}");
        }

        public override string ToString()
        {
            return base.ToString() + $", Topic: {Topic}";
        }
    }
}
