using HelpDesk.Models;

namespace HelpDesk.Data
{
    public class AppDb
    {
        public List<Cliente> Clientes { get; set; } = new();
        public List<Tecnico> Tecnicos { get; set; } = new();
        public List<Chamado> Chamados { get; set; } = new();

        private int _clienteSeq = 1;
        private int _tecnicoSeq = 1;
        private int _chamadoSeq = 1;

        public int NextClienteId() => _clienteSeq++;
        public int NextTecnicoId() => _tecnicoSeq++;
        public int NextChamadoId() => _chamadoSeq++;

        public AppDb()
        {
            Clientes.AddRange(new[]
            {
                new Cliente { Id = NextClienteId(), Nome = "João Silva", Empresa = "ACME", Email = "joao@acme.com" },
                new Cliente { Id = NextClienteId(), Nome = "Maria Souza", Empresa = "Beta Ltda", Email = "maria@beta.com" }
            });

            Tecnicos.AddRange(new[]
            {
                new Tecnico { Id = NextTecnicoId(), Nome = "Carlos Almeida", Especialidade = "Redes", Email = "carlos@empresa.com" },
                new Tecnico { Id = NextTecnicoId(), Nome = "Ana Beatriz", Especialidade = "Hardware", Email = "ana@empresa.com" }
            });

            Chamados.AddRange(new[]
            {
                new Chamado {
                    Id = NextChamadoId(),
                    Titulo = "Erro ao abrir sistema",
                    Descricao = "Aplicação fecha ao iniciar",
                    ClienteId = Clientes[0].Id,
                    TecnicoId = Tecnicos[0].Id,
                    Prioridade = PrioridadeChamado.Alta,
                    Status = StatusChamado.Aberto
                },
                new Chamado {
                    Id = NextChamadoId(),
                    Titulo = "Máquina não liga",
                    Descricao = "Após queda de energia",
                    ClienteId = Clientes[1].Id,
                    TecnicoId = Tecnicos[1].Id,
                    Prioridade = PrioridadeChamado.Media,
                    Status = StatusChamado.EmAndamento
                }
            });
        }
    }
}
