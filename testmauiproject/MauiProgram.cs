using Microsoft.Extensions.Logging;

namespace testmauiproject
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("ABCWalterNeue-Mager.ttf", "WalterNeue-Mager");
                    fonts.AddFont("ABCWalterNeue-Mittel.ttf", "WalterNeue-Mittel");
                    fonts.AddFont("ABCWalterNeue-Normal.ttf", "WalterNeue-Normal");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
