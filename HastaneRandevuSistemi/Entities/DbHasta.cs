﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneRandevuSistemi.Entities
{
    [Table("Hastas")]
    public class DbHasta
    {
        [Key] 
        public Guid HastaId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }


     
        public ICollection<DbRandevu>? randevus;
    }
}
