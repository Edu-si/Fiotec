using DevIO.Business.Intefaces;
using DevIO.Business.Models.Validations;
using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Services
{
    public class RelatorioService : BaseService, IRelatorioService
    {
        private readonly IRelatorioRepository _relatorioRepository;

        public RelatorioService(IRelatorioRepository relatorioRepository,
                              INotificador notificador) : base(notificador)
        {
            _relatorioRepository = relatorioRepository;
        }

        public async Task Adicionar(Relatorio relatorio)
        {
            await _relatorioRepository.Adicionar(relatorio);
        }

        public void Dispose()
        {
            _relatorioRepository?.Dispose();
        }
    }
}
