using dotnet_tack.Data;
using Microsoft.EntityFrameworkCore;

namespace dotnet_tack;

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
            });

        // Ajouter AppDbContext au conteneur DI
        var connectionString = "server=localhost;database=dotnet_tack;user=root;password=";
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        return builder.Build();
    }
}
