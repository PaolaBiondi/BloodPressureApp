using BloodPressure.Infrastructure.Persistence.EFC.SQLite.Extensions;
using BloodPressureLogApp.Extensions;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace BloodPressureLogApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("fontello.ttf", "Icons");
                });

            builder.Services.AddCustomDbContext();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddAppPages();

            return builder.Build();
        }
    }
}
