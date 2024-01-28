using System.ComponentModel.DataAnnotations;

namespace BasicMembership.Models.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Geçerli bir değer giriniz.")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "Geçerli bir değer giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Geçerli bir değer giriniz.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Geçerli bir değer giriniz.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Geçerli bir değer giriniz.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Paralolar uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
        public string? UserName { get; set; }
        public string? Role { get; set; }
    }
}
