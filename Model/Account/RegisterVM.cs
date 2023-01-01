using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Account
{
    public class RegisterVM
    {
        [DisplayName("İsim")]
        [Required(ErrorMessage = "Boş bırakılamaz.")]
        [MinLength(2, ErrorMessage = "En az 2 karakter olabilir.")]
        [MaxLength(30, ErrorMessage = "En fazla 30 karakter olabilir.")]
        public string Name { get; set; }

        [DisplayName("Soyisim")]
        [Required(ErrorMessage = "Boş bırakılamaz.")]
        [MinLength(2, ErrorMessage = "En az 2 karakter olabilir.")]
        [MaxLength(30, ErrorMessage = "En fazla 30 karakter olabilir.")]
        public string Surname { get; set; }

        [DisplayName("Yaş")]
        [Required(ErrorMessage = "Boş bırakılamaz.")]
        [Range(15,100, ErrorMessage = "En az 15, en fazla 100 olabilir.")]
        public short Age { get; set; }

        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "Boş bırakılamaz.")]
        [MinLength(2, ErrorMessage = "En az 2 karakter olabilir.")]
        [MaxLength(30, ErrorMessage = "En fazla 30 karakter olabilir.")]
        public string Username { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "Boş bırakılamaz.")]
        [MinLength(6, ErrorMessage = "En az 6 karakter olabilir.")]
        [MaxLength(18, ErrorMessage = "En fazla 18 karakter olabilir.")]
        public string Password { get; set; }

        [DisplayName("Şifre Tekrarı")]
        [Required(ErrorMessage = "Boş bırakılamaz.")]
        [MinLength(6, ErrorMessage = "En az 6 karakter.")]
        [MaxLength(18, ErrorMessage = "En fazla 18 karakter.")]
        [Compare(nameof(Password), ErrorMessage = "Şifreler uyuşmuyor.")]
        public string RePassword { get; set; }
    }
}
