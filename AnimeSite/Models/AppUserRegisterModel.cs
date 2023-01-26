using System.ComponentModel.DataAnnotations;

namespace AnimeSite.Models
{
    public class AppUserRegisterModel
    {
        [Required(ErrorMessage ="Lütfen Email Giriniz.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Giriniz.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Tekrarı Giriniz.")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil")]
        public string ConfirmPassoword { get; set; }
    }
}
