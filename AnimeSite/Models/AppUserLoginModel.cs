using System.ComponentModel.DataAnnotations;

namespace AnimeSite.Models
{
    public class AppUserLoginModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Giriniz.")]
        public string Password { get; set; }
    }
}
