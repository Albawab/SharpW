using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

namespace Identity_UserManager_Auhtentication
{
    public static class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true).AddJsonFile(
                 $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development"}.json",
                 true).AddEnvironmentVariables().Build();

        public static void Main(string[] args)
        {
            Console.Title = Constanten.ApplicatieNaam;

/*            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Information)
                .ReadFrom.Configuration(Configuration)
                .Enrich.FromLogContext()
                .Enrich.WithProperty("Application", Constanten.ApplicatieNaam)
                .WriteTo.Console(outputTemplate: Constanten.LogOutputTemplate, theme: AnsiConsoleTheme.Literate)
                .WriteTo.Seq(Environment.GetEnvironmentVariable("SEQ_URL").CoalesceTo(Properties.Resources.DefaultSeqUrl))
                .CreateLogger();*/
            try
            {
                Log.Information(Constanten.MeldingOpstarten, Constanten.ApplicatieNaam);

                Log.Information("Getting the motors running...");

                var seed = args.Contains("/seed");
                if (seed)
                {
                    args = args.Except(new[] { "/seed" }).ToArray();
                }

                var host = CreateHostBuilder(args).Build();

                if (seed)
                {
                    Log.Information("Seeding database...");
                    var config = host.Services.GetRequiredService<IConfiguration>();
                    var connectionString = config.GetConnectionString("AeolusAuth");
                    SeedData.EnsureSeedData(connectionString);
                    Log.Information("Done seeding database.");
                    return;
                }

                Log.Information("Starting host...");
                host.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, Applicatie.Meldingen.OnverwachtGestopt);

                throw;
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
                })
  /*              .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.AddSerilog(dispose: true);
                })*/;
    }
}
