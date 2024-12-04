namespace program_lab2
{
    // Класс Автор
    public class Author : Person
    {
        private Genres favoriteGenre;
        public Genres FavoriteGenre
        {
            get
            {
                return favoriteGenre;
            }
            set 
            {
                if (value.) { }
            }
        }

        public Author(string name, int age, Genres favoriteGenre) : base(name, age)
        {
            FavoriteGenre = favoriteGenre;
        }
        public override string ToString()
        {
            return base.ToString() + $", FavoriteGenre: {FavoriteGenre}";
        }
    }
}
