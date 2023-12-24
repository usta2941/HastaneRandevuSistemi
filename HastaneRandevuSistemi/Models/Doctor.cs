using Microsoft.Extensions.Hosting;

namespace HastaneRandevuSistemi.Models
{
    public class Doctor
    {
        public Guid DoctorId { get; set; }
        public string? Name { get; set; }
        public string? Deparmant { get; set; }
        public DateTime start { get; set; } // mesai başlangıcı
        public DateTime end { get; set; } // mesai bitişi

        public DateTime breakTime { get; set; } // öğlen arası

        public string? Description { get; set; } // doktor için kısa bir tanıtım metni
    }
}
