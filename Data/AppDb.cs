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
            // --- CLIENTES (8) ---
            Clientes.AddRange(new[]
            {
                new Cliente { Id = NextClienteId(), Nome = "João Silva", Empresa = "ACME", Email = "joao@acme.com" },
                new Cliente { Id = NextClienteId(), Nome = "Maria Souza", Empresa = "Beta Ltda", Email = "maria@beta.com" },
                new Cliente { Id = NextClienteId(), Nome = "Pedro Santos", Empresa = "TechCorp", Email = "pedro@techcorp.com" },
                new Cliente { Id = NextClienteId(), Nome = "Juliana Lima", Empresa = "SoftPlus", Email = "juliana@softplus.com" },
                new Cliente { Id = NextClienteId(), Nome = "Rafael Costa", Empresa = "InfoWay", Email = "rafael@infoway.com" },
                new Cliente { Id = NextClienteId(), Nome = "Lucas Rocha", Empresa = "DataLink", Email = "lucas@datalink.com" },
                new Cliente { Id = NextClienteId(), Nome = "Camila Martins", Empresa = "AlphaDev", Email = "camila@alphadev.com" },
                new Cliente { Id = NextClienteId(), Nome = "Bruno Pereira", Empresa = "NextSoft", Email = "bruno@nextsoft.com" }
            });

            // --- TÉCNICOS (8) ---
            Tecnicos.AddRange(new[]
            {
                new Tecnico { Id = NextTecnicoId(), Nome = "Carlos Almeida", Especialidade = "Redes", Email = "carlos@empresa.com" },
                new Tecnico { Id = NextTecnicoId(), Nome = "Ana Beatriz", Especialidade = "Hardware", Email = "ana@empresa.com" },
                new Tecnico { Id = NextTecnicoId(), Nome = "Bruno Ferreira", Especialidade = "Software", Email = "bruno@empresa.com" },
                new Tecnico { Id = NextTecnicoId(), Nome = "Patrícia Gomes", Especialidade = "Banco de Dados", Email = "patricia@empresa.com" },
                new Tecnico { Id = NextTecnicoId(), Nome = "Rodrigo Lopes", Especialidade = "Segurança", Email = "rodrigo@empresa.com" },
                new Tecnico { Id = NextTecnicoId(), Nome = "Larissa Farias", Especialidade = "Suporte N1", Email = "larissa@empresa.com" },
                new Tecnico { Id = NextTecnicoId(), Nome = "Diego Carvalho", Especialidade = "DevOps", Email = "diego@empresa.com" },
                new Tecnico { Id = NextTecnicoId(), Nome = "Sofia Mendes", Especialidade = "Virtualização", Email = "sofia@empresa.com" }
            });

            // --- CHAMADOS (8) ---
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
                },
                new Chamado {
                    Id = NextChamadoId(),
                    Titulo = "Problema na rede",
                    Descricao = "Sem conexão com a internet",
                    ClienteId = Clientes[2].Id,
                    TecnicoId = Tecnicos[2].Id,
                    Prioridade = PrioridadeChamado.Alta,
                    Status = StatusChamado.Aberto
                },
                new Chamado {
                    Id = NextChamadoId(),
                    Titulo = "Impressora travando",
                    Descricao = "Não responde aos comandos",
                    ClienteId = Clientes[3].Id,
                    TecnicoId = Tecnicos[3].Id,
                    Prioridade = PrioridadeChamado.Baixa,
                    Status = StatusChamado.EmAndamento
                },
                new Chamado {
                    Id = NextChamadoId(),
                    Titulo = "Erro de login",
                    Descricao = "Usuário não consegue acessar o sistema",
                    ClienteId = Clientes[4].Id,
                    TecnicoId = Tecnicos[4].Id,
                    Prioridade = PrioridadeChamado.Media,
                    Status = StatusChamado.Aberto
                },
                new Chamado {
                    Id = NextChamadoId(),
                    Titulo = "Sistema lento",
                    Descricao = "Demora para carregar as páginas",
                    ClienteId = Clientes[5].Id,
                    TecnicoId = Tecnicos[5].Id,
                    Prioridade = PrioridadeChamado.Baixa,
                    Status = StatusChamado.EmAndamento
                },
                new Chamado {
                    Id = NextChamadoId(),
                    Titulo = "Monitor com falha",
                    Descricao = "Tela piscando constantemente",
                    ClienteId = Clientes[6].Id,
                    TecnicoId = Tecnicos[6].Id,
                    Prioridade = PrioridadeChamado.Media,
                    Status = StatusChamado.Aberto
                },
                new Chamado {
                    Id = NextChamadoId(),
                    Titulo = "Falha no backup",
                    Descricao = "Backup não foi executado",
                    ClienteId = Clientes[7].Id,
                    TecnicoId = Tecnicos[7].Id,
                    Prioridade = PrioridadeChamado.Alta,
                    Status = StatusChamado.EmAndamento
                }
            });
        }
    }
}
