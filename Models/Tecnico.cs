using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class Tecnico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(120)]
        public string Nome { get; set; } = string.Empty;

        [EmailAddress]
        [StringLength(160)]
        public string? Email { get; set; }

        [Phone]
        [StringLength(40)]
        public string? Telefone { get; set; }

        [StringLength(120)]
        public string? Especialidade { get; set; }
    }
}