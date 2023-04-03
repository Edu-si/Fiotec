using DevIO.Business.Models;

namespace Aplicacao.Model
{
    public class RelatorioView
    {
        public Guid ClienteId { get; set; }
        public string NomeSolicitante { get; set; }

        public string Descricao { get; set; }

        public DateTime DataAplicacao { get; set; }

        public DateTime DataSolicitacao { get; set; }

        public int QuantidadeTotal { get; set; }

        public IEnumerable<Cliente> cliente { get; set; }
    }
}
