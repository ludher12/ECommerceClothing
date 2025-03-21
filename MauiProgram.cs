using ECommerceCloting.Service;
using ECommerceCloting.ViewModel;
using Microsoft.Extensions.Logging;

namespace ECommerceCloting
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
                    fonts.AddFont("EncodeSans.ttf","EncodeSans");
                });
            builder.Services.AddSingleton<ProductService>();
            builder.Services.AddTransient<ProductMainViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
