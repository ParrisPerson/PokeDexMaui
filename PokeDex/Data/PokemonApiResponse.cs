using System;
using System.Text.Json.Serialization;

namespace PokeDex.Data
{
    public class PokemonApiResponse
    {
        [JsonPropertyName("results")]
        public List<PokemonResult> Results { get; set; }
    }
}

