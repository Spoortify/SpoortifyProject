using Microsoft.Extensions.Logging;
using Sportify.View;

namespace Sportify
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
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("fontBoom.ttf", "fontBoom");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();

        }
    }
}