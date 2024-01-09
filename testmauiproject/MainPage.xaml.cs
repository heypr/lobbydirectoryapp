using Microsoft.Maui.Controls;
using MyMauiApp;

namespace testmauiproject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new TimeViewModel();
        }

        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Text)
                {
                    // Navigate to the appropriate page based on the button clicked Add more buttons as needed
                    case "Local Amenities":
                        // Navigate to Local Amenities Page
                        await Shell.Current.GoToAsync(nameof(Amenities));
                        break;
                    case "Leasing Information":
                        // Navigate to Leasing Information Page
                        await Shell.Current.GoToAsync(nameof(Leasing));
                        break;
                    default:
                        // Navigate to About Page
                        await Shell.Current.GoToAsync(nameof(AboutPage));
                        break;
                }
            }
        }
    }
}

