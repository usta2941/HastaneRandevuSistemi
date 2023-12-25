namespace HastaneRandevuSistemi.Models
{
    public class Hasta
    {
        
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Guid DoktorId { get; set; } // Hasta ile Doktor arasındaki db için ilişki
        public Doctor? Doktor { get; set; } // db ile doktor bilgisine erişim (navigation property)
    }
}
