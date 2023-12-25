﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneRandevuSistemi.Entities
{
    [Table("Randevus")]
    public class DbRandevu
    {
        [Key] 
        public Guid RandevuId { get; set; }
        public DateTime Tarih { get; set; } // gün ay yıl saat dk bilgisini tutar

        [ForeignKey("HastaId")]
        [Required]
        public DbHasta? Hasta { get; set; } // Navigation property db hızlı erişim
        
    }
}
