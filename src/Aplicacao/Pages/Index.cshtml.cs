using Aplicacao.Model;
using AutoMapper;
using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Configuration;
using Xunit;

namespace Aplicacao.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;


        public IndexModel(ILogger<IndexModel> logger, IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
            _logger = logger;
        }
        
        public IActionResult OnGet()
        {
                return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            try
            {

                ClienteView clienteView = new ClienteView();

                clienteView.Nome = Request.Form["nome"]; 
                clienteView.Cpf = Request.Form["cpf"];
                clienteView.DataAplicacao = Convert.ToDateTime(Request.Form["dataAplicacao"]);

                var Id =  await _clienteService.Adicionar(_mapper.Map<Cliente>(clienteView));
               
                return RedirectToPage("./Relatorio", new { IdGuid = Id});
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "");

                return RedirectToAction("./Index");
            }
        }

    }
}