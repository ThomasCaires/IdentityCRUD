using System.ComponentModel.DataAnnotations;

namespace IdentityCRUD.Entities
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        [Required, MaxLength(80, ErrorMessage = "Nome não pode exder 80 caracteres")]
        public string? Nome { get; set; }

        [EmailAddress]
        [Required, MaxLength(120)]
        public string? Email { get; set; }

        public int Idade { get; set; }

        [MaxLength(80)]
        public string? Curso { get; set; }
    }
}
