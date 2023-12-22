using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="isim boş bırakılamaz")]
        [StringLength(30, ErrorMessage ="isim 30'dan büyük olamaz")]
        public string? Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "şifre boş bırakılamaz")]
        [MinLength(6, ErrorMessage ="en az 6 karakter olmalı")]
        [MaxLength(25, ErrorMessage ="en fazla 25 karakter olabilir")]
        public string Password { get; set; }  
        public string? Email { get; set; }
    }
}
