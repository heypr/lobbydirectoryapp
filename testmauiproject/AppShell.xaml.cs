using Microsoft.Maui.Controls;
using MyMauiApp;

namespace testmauiproject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes for your pages
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(Amenities), typeof(Amenities));
            Routing.RegisterRoute(nameof(Leasing), typeof(Leasing));
        }
    }
}
