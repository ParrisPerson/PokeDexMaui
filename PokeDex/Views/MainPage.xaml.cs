using PokeDex.ViewModels;
using PokeDex.Views;
using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace PokeDex;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is MainViewModel viewModel)
        {
            viewModel.LoadData();
        }
    }

    private async void OnSelectedPokemonChanged()
    {
        if (BindingContext is MainViewModel viewModel && viewModel.SelectedPokemon != null)
        {

            PokemonDetailViewModel detailViewModel = new PokemonDetailViewModel();
           
            PokemonDetailPage detailPage = new PokemonDetailPage
            {
                BindingContext = detailViewModel
            };

            detailPage.url = viewModel.SelectedPokemon.url;

            await Navigation.PushAsync(detailPage);
            viewModel.SelectedPokemon = null;
        }
    }

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        if (BindingContext is MainViewModel viewModel)
        {
            viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }
    }

    private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(MainViewModel.SelectedPokemon))
        {
            OnSelectedPokemonChanged();
        }
    }

}


