using System;
using System.Text.Json;

namespace PokeDex.Data
{
	public class ApiManager
	{
        private static readonly Lazy<ApiManager> instance = new Lazy<ApiManager>(() => new ApiManager());
        public static ApiManager Instance => instance.Value;


        private ApiManager()
        {
            //Constructor privado para evitar la creación directa de instancias
        }

        private const string apiUrl = "https://pokeapi.co/api/v2/pokemon";

        public async Task<List<PokemonResult>> GetPokemonListAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync(apiUrl+ "?limit=20");
                PokemonApiResponse response = JsonSerializer.Deserialize<PokemonApiResponse>(result);
                return response.Results;
            }
        }

        public async Task<PokemonDetail> GetPokemonAsync(String url)
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync(url);
                PokemonDetail response = JsonSerializer.Deserialize<PokemonDetail>(result);
                return response;
            }
        }
    }
}

