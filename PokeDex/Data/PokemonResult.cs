using System;
using System.Text.Json.Serialization;

namespace PokeDex.Data
{
    public class PokemonResult
    {
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("url")]
        public string url { get; set; }

    }
}

