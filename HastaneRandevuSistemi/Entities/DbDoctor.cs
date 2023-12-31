﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaneRandevuSistemi.Entities
{
    [Table("Doctors")]
    public class DbDoctor
    {
        [Key]
        public Guid DoctorId { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(100)]
        public DateTime start { get; set; } // mesai başlangıcı
        public DateTime end { get; set; } // mesai bitişi

        public DateTime breakTime { get; set; } // öğlen arası

        public string? Description { get; set; } // doktor için kısa bir tanıtım metni

        public Clinic? clinic { get; set; }

        [ForeignKey("clinic")]
        public Guid clinicId { get; set; }

        public ICollection<DbRandevu>? Randevus { get; set; }
    }
}
