namespace Demo_Product.Models
{
    public class UserLoginViewModel
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kullanıcı adınızı girin.")]
        public string UserName { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Şifrenizi girin.")]
        public string Password { get; set; }
    }
}
