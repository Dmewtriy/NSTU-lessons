using program_lab2;

namespace program_lab2_tests
{
    // Временный дочерний класс для тестирования абстрактного класса PrintedEdition
    public class TestPrintedEdition : PrintedEdition
    {
        public TestPrintedEdition(string title, int year, Author author, Publishing publishing)
            : base(title, year, author, publishing)
        {
        }

        public override void Read()
        {
            // Пустая реализация для тестов
        }
    }
}
