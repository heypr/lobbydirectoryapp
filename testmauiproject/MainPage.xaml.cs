namespace testmauiproject
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(AboutPage));
        }
    }

}
