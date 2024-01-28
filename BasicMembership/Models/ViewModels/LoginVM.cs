using System.ComponentModel.DataAnnotations;

namespace BasicMembership.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Geçerli bir değer giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Geçerli bir değer giriniz.")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
