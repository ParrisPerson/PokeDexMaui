using System;
using System.Text.Json.Serialization;

namespace PokeDex.Data
{
    public class SpriteData
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }
}

