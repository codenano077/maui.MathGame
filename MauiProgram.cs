using Microsoft.Extensions.Logging;
using MathGame.Maui.Data;
namespace Maui.MathGame
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
                    fonts.AddFont("BitcountGridDoubleInk-VariableFont.ttf", "BitcountGridDoubleInkVariableFont");
                });
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "game.db");
            builder.Services.AddSingleton(s => 
                ActivatorUtilities.CreateInstance<GameRepo>(s, dbPath));

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
