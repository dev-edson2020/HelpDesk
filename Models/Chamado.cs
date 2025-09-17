namespace HelpDesk.Models
{
    public enum StatusChamado
    {
        Aberto,
        EmAndamento,
        Concluido
    }

    public enum PrioridadeChamado
    {
        Baixa,
        Media,
        Alta
    }

    public class Chamado
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }

        public int ClienteId { get; set; }
        public int TecnicoId { get; set; }

        public PrioridadeChamado Prioridade { get; set; } = PrioridadeChamado.Media;
        public StatusChamado Status { get; set; } = StatusChamado.Aberto;

        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
}