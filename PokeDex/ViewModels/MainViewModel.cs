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
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<PokemonResult> pokemonList;
        public List<PokemonResult> PokemonList
        {
            get { return pokemonList; }
            set
            {
                pokemonList = value;
                OnPropertyChanged(nameof(PokemonList));
            }
        }

        private PokemonResult _selectedPokemon;
        public PokemonResult SelectedPokemon
        {
            get { return _selectedPokemon; }
            set
            {
                _selectedPokemon = value;
                OnPropertyChanged(nameof(SelectedPokemon));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async void LoadData()
        {
            PokemonList = await ApiManager.Instance.GetPokemonListAsync();
        }
    }
}
