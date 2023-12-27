using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HastaneRandevuSistemi.Entities
{
    public class Clinic
    {
        [Key]
        public Guid clinicId { get; set; }
        public string? clinicName { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public ICollection<DbDoctor>? doctors { get; set; }
    }
}
