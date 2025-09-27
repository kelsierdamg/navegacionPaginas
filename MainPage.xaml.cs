namespace navegacionPaginas
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void AboutBtn(object sender, EventArgs e)
        {
            // Navegar a Page2
            await Navigation.PushAsync(new Page2());
        }

        private async void ContactBtn(object sender, EventArgs e)
        {
            // Navegar a Page2
            await Navigation.PushAsync(new Page3());
        }
    }
}
