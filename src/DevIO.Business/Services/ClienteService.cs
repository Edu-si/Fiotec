using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using DevIO.Business.Models.Validations;

namespace DevIO.Business.Services
{
    public class ClienteService : BaseService, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository produtoRepository,
                              INotificador notificador) : base(notificador)
        {
            _clienteRepository = produtoRepository;
        }

        public async Task<Guid> Adicionar(Cliente cliente)
        {
            await _clienteRepository.Adicionar(cliente);

            return cliente.Id;
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }

      
    }
}