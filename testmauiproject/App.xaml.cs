namespace testmauiproject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            Window window = base.CreateWindow(activationState);
            window.MinimumWidth = 1080;
            window.MinimumHeight = 1920;
            window.MaximumHeight = 1920;
            window.MaximumWidth = 1080;
            return window;
        }
    }
}
