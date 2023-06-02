using Microsoft.Maui.Controls;
using PokeDex.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.ViewModels
{
    public class PokemonDetailViewModel : INotifyPropertyChanged
    {
        private PokemonDetail _pokemonDetail;
        
        public PokemonDetail pokemonDetail
        {
            get { return _pokemonDetail; }
            set
            {
                _pokemonDetail = value;
                OnPropertyChanged(nameof(pokemonDetail));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async void LoadPokemon(String url)
        {
            pokemonDetail = await ApiManager.Instance.GetPokemonAsync(url);
        }
    }
}

