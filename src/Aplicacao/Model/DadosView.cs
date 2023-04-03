using Newtonsoft.Json;

namespace Aplicacao.Model
{

    public class DadosView1
    {
        [JsonProperty(PropertyName = "took")]
        public string took { get; set; }

        //[JsonProperty(PropertyName = "hits")]
        //public _Source _source { get; set; }   
    }

    public class _Source
    {
        public string paciente_id { get; set; } 
        public string vacina_fabricante_nome { get; set; }      
        public string estabelecimento_uf { get; set; }
        public string vacina_dataAplicacao { get; set; }

    }
}
