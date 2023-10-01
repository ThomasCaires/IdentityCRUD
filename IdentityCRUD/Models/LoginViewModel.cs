using System.ComponentModel.DataAnnotations;

namespace IdentityCRUD.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email obrigatorio")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatoria")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Lembrar sempre")]
        public bool RememberMe { get; set;}

    }
}
