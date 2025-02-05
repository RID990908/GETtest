using Serilog;

namespace HostalIslaAzul.API;

public class Program
{
    public static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/hostal-log-.txt", rollingInterval: RollingInterval.Day)
            // .WriteTo.Seq("http://localhost:5341") // Opcional: usar Seq para logging centralizado
            .Enrich.FromLogContext()
            .CreateLogger();

        try
        {
            Log.Information("Iniciando aplicación HostalIslaAzul");
            CreateHostBuilder(args).Build().Run();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "La aplicación no pudo iniciarse");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}