using System.Text.Json.Serialization;

namespace crud.Models
{
    public class AeroportoDto
    {
        public int Umidade { get; set; }
        public string Visibilidade { get; set; }

        [JsonPropertyName("codigo_icao")]
        public string CodigoICAO { get; set; }
        
        [JsonPropertyName("pressao_atmosferica")]
        public int PressaoAtmosferica { get; set; }
        public int Vento { get; set; }

        [JsonPropertyName("direcao_vento")]
        public int DirecaoVento { get; set; }
        public string Condicao { get; set; }
        [JsonPropertyName("condicao_desc")]
        public string CondicaoDesc { get; set; }
        public int Temperatura { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}