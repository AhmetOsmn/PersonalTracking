using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Account
{
    public class LoginVM
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "Boş bırakılamaz.")]
        public string Username { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "Boş bırakılamaz.")]
        public string Password { get; set; }
    }
}
