using PokeDex.ViewModels;
namespace PokeDex.Views;

public partial class PokemonDetailPage : ContentPage
{
    public String url;

	public PokemonDetailPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is PokemonDetailViewModel viewModel)
        {
            viewModel.LoadPokemon(url: url);
        }
    }
}
