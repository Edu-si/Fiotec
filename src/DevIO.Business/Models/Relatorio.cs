using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Models
{
    public class Relatorio : Entity
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
