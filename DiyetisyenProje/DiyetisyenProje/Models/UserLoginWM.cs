using System.ComponentModel.DataAnnotations;

namespace DiyetisyenProje.Models
{
    public class UserLoginWM
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string password { get; set; }
    }
}
