using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Intefaces
{
    public interface IClienteService : IDisposable
    {
        Task<Guid> Adicionar(Cliente cliente);
      
    }
}
