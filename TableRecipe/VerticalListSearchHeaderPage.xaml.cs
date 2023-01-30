namespace TableRecipe
{
    public partial class VerticalListSearchHeaderPage : ContentPage
    {
        private readonly VerticalListSearchHeaderViewModel _viewModel
            = new();

        public VerticalListSearchHeaderPage()
        {
            InitializeComponent();
            BindingContext = _viewModel;
        }

        void MainSearchBar_TextChanged(System.Object sender,
            Microsoft.Maui.Controls.TextChangedEventArgs e)
        {
            MainSearchBar.Focus();
        }
    }
}
