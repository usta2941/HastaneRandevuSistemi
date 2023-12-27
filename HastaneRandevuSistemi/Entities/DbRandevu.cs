
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HastaneRandevuSistemi.Entities
{
    public class DbRandevu
    {
        [Key] 
        public Guid RandevuId { get; set; }
        public DateTime Tarih { get; set; } // gün ay yıl saat dk bilgisini tutar


        [ForeignKey("Hasta")]
        public Guid HastaID { get; set; }  // one to one
        [JsonIgnore]
        [IgnoreDataMember]
        public DbHasta? Hasta { get; set; } // Navigation property db hızlı erişim

        [ForeignKey("Doktor")]
        public Guid DoktorId { get; set; }  // one to one
        public DbDoctor? Doktor { get; set; } // Navigation property db hızlı erişim

    }
}
