using System;
using System.Text.Json.Serialization;

namespace PokeDex.Data
{
	public class PokemonDetail
	{
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("weight")]
        public int weight { get; set; }
        [JsonPropertyName("sprites")]
        public SpriteData sprites { get; set; }
    }
}

