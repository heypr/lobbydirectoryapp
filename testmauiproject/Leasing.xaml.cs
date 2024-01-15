using Microsoft.Maui.Controls;
using System;

namespace MyMauiApp
{
    public partial class Leasing : ContentPage
    {
        public Leasing()
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