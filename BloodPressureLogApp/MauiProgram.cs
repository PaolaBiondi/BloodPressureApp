using BloodPressure.Infrastructure.Persistence.EFC.SQLite.Extensions;
using BloodPressureLogApp.Extensions;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace BloodPressureLogApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF5cXmZCfUx1RXxbf1x0ZFZMZV9bRXJPMyBoS35RckVgW3xec3FWR2RUU0Zz");

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseSkiaSharp()
                .ConfigureSyncfusionCore()
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
