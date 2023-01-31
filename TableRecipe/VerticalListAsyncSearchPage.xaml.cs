namespace TableRecipe;

public partial class VerticalListAsyncSearchPage : ContentPage
{
    private readonly VerticalListAsyncSearchViewModel _viewModel =
        new();

    public VerticalListAsyncSearchPage()
    {
        InitializeComponent();
        BindingContext = _viewModel;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.Initialize();
    }

    void MainSearchBar_TextChanged(
        System.Object sender,
        Microsoft.Maui.Controls.TextChangedEventArgs e
    )
    {
        MainSearchBar.Focus();
    }
}
