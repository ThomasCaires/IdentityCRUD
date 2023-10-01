using System.ComponentModel.DataAnnotations;

namespace IdentityCRUD.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Conforme sua senha")]
        [Compare("Password", ErrorMessage ="As senhas não conferem")]
        public string? ConfirmPassword { get; set;}
    }
}
