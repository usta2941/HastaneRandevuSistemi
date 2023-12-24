namespace HastaneRandevuSistemi.Models
{
    public class Randevu
    {
        public Guid RandevuId { get; set; }
        public DateTime Tarih { get; set; } // gün ay yıl saat dk bilgisini tutar
        public Guid HastaId { get; set; } // Randevu ile Hasta arasındaki db için ilişki
        public Guid DoktorId { get; set; } // Randevu ile doktor arasındaki db için ilişki

        public Hasta? Hasta { get; set; } // Navigation property db hızlı erişim
        public Doctor? Doktor { get; set; } // Navigation property db hızlı erişim
    }
}
