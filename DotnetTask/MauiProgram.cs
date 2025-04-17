using DotnetTask;
using Microsoft.EntityFrameworkCore;
using DotnetTask.Data;
using DotnetTask.Views;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        string connectionString = "server=localhost;database=DotnetTask;user=root;password=";

        builder.Services.AddDbContext<TaskDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        builder.Services.AddSingleton<MainPage>(); // Exemple

        return builder.Build();
    }
}