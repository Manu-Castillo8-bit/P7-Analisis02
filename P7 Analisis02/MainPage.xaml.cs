namespace P7_Analisis02
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
             Navigation.PushAsync(new Pagina2());
        }


        private void OnCounterClicked1(object? sender, EventArgs e)
        {
             Navigation.PushAsync(new Pagina3());
        }

    }
}
