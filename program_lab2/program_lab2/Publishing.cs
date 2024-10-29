namespace program_lab2
{
    // Класс Издательство
    public class Publishing
    {
        public string Name { get; }
        public string Address { get; }

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
