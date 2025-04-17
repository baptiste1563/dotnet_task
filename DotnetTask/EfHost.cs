#if DEBUG && EF
using DotnetTask.Data; // adapte avec ton namespace
using Microsoft.EntityFrameworkCore;
using System;

public class EfHost
{
    public static void Main(string[] args)
    {
        var builder = MauiApp.CreateBuilder();

        string connectionString = "server=localhost;database=DotnetTask;user=root;password=";

        var options = new DbContextOptionsBuilder<TaskDbContext>()
            .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)).Options;


        using var db = new TaskDbContext(options);
        db.Database.Migrate();
    }
}
#endif