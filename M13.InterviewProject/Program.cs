namespace M13.InterviewProject;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Configuration
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true)
            .AddEnvironmentVariables();

        builder.Services.AddControllers();

        builder.Logging.AddConsole().AddDebug();

        var app = builder.Build();

        app.MapControllers();

        app.Run();
    }
}