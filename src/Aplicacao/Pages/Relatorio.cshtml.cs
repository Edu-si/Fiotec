using Aplicacao.Model;
using AutoMapper;
using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Text;
using System.Web;

namespace Aplicacao.Pages
{
    public class RelatorioModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        private readonly IClienteService _clienteService;
        private readonly IClienteRepository _clienteRepository;
        private readonly IRelatorioService _relatorioService;
        private readonly IMapper _mapper;


        public RelatorioModel(ILogger<IndexModel> logger, IClienteService clienteService, IMapper mapper, IRelatorioService relatorioService, IClienteRepository clienteRepository)
        {
            _clienteService = clienteService;
            _mapper = mapper;
            _logger = logger;
            _relatorioService = relatorioService;
            _clienteRepository = clienteRepository;
        }
        [BindProperty()]
        public Guid IdGuid { get; set; }
        [BindProperty()]
        public ClienteView clienteView { get; set; }

        public async void OnGet(Guid IdGuid)
        {
           
            var cliente = await _clienteRepository.ObterPorId(IdGuid);
            var clienteView = _mapper.Map<ClienteView>(cliente);

            RelatorioView relatorioView = new RelatorioView();

            relatorioView.ClienteId = clienteView.Id;
            relatorioView.NomeSolicitante = clienteView.Nome;
            relatorioView.Descricao = "Relatório Vacinas Pfizer aplicadas" + clienteView.DataAplicacao;
            relatorioView.DataSolicitacao = clienteView.DataAplicacao;
            relatorioView.DataAplicacao = clienteView.DataAplicacao;

            await _relatorioService.Adicionar(_mapper.Map<Relatorio>(relatorioView));

            Console.WriteLine("LEITURA DOS DADOS DA API");
            string username = "imunizacao_public";
            string password = "qlto5t&7r_@+#Tlstigi";
            var base64String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));

            var client = new RestClient("https://imunizacao-es.saude.gov.br/");
            var authenticator = new HttpBasicAuthenticator("imunizacao_public", "qlto5t&7r_@+#Tlstigi");
            var request = new RestRequest("_search", RestSharp.Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Basic " + base64String);
            request.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode("https://imunizacao-es.saude.gov.br/_search", Encoding.UTF8));
            var response = client.Execute(request);
            Console.WriteLine("FIM DA LEITURA DOS DADOS DA API");
            //Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Content);
 
            
            //var dados = ser.Deserialize<Dictionary<string, object>>(response.Content);
            var dados = JsonConvert.DeserializeObject<List<DadosView1>>(response.Content);
           
            foreach (var item in dados)
            {
                
            }

            Console.ReadKey(true);
        

            Page();

        }

    }
}
