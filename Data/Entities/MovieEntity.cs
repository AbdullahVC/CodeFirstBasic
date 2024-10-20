namespace CodeFirstBasic.Data.Entities
{
    public class MovieEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } // Filmin başlığı
        public string Genre { get; set; } // Filmin türü
        public int ReleaseYear { get; set; } // Filmin çıkış yılı
    }

}
