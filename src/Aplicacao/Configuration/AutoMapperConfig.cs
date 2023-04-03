using Aplicacao.Model;
using AutoMapper;
using DevIO.Business.Models;

namespace Aplicacao.Configuration
{
    public class AutoMapperConfig : Profile
    {

        public AutoMapperConfig()
        {

            CreateMap<Cliente, ClienteView>().ReverseMap();
            CreateMap<ClienteView, Cliente>().ReverseMap();
            CreateMap<Relatorio, RelatorioView>().ReverseMap();
        }
    }
}
