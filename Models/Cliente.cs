using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(120, ErrorMessage = "O nome pode ter no máximo 120 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        [StringLength(160)]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Telefone inválido.")]
        [StringLength(40)]
        public string? Telefone { get; set; }

        [StringLength(160)]
        public string? Empresa { get; set; }

        public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    }
}