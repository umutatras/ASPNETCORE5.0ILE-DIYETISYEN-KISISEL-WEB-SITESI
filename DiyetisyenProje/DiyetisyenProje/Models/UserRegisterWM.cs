using System.ComponentModel.DataAnnotations;

namespace DiyetisyenProje.Models
{
    public class UserRegisterWM
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz")]
        public string name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınız giriniz")]
        public string surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen telefon giriniz")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Lütfen Mail giriniz")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre giriniz")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar giriniz")]
        public string confirmpassword { get; set; }
    }
}
