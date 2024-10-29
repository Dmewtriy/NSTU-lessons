namespace program_lab2
{
    public static class StringExtension
    {
        public static string AddCommaAfterEachWord(this string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            return string.Join(", ", input.Split(' '));
        }
    }
}
