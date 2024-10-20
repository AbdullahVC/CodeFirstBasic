namespace CodeFirstBasic.Data.Entities
{
    public class GameEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } // Oyunun adı
        public string Platform { get; set; } // Oyunun oynandığı platform
        public decimal Rating { get; set; } // Oyunun puanı (0 ile 10 arasında)
    }

}
