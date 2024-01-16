namespace MyMauiApp
{
    public partial class Amenities : ContentPage
    {
        public Amenities()
        {
            InitializeComponent();
        }

        private void OnHomeButtonClicked(object sender, EventArgs e)
        {
            // Navigate to the home page
            Navigation.PopToRootAsync();
        }
    }
}