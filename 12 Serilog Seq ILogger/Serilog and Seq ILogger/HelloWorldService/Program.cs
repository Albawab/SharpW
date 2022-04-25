// See https://aka.ms/new-console-template for more information

using HelloWorldService;
using HelloWorldService.Properties;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.Seq(Resources.DefaultSeqUrl)
    .CreateLogger();

try
{
    Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddHostedService<Worker>(); // alleen om te cheken of het workt.
                                             // als met api of .net werkt dan kan ik app.UseSerilogRequestLogging(); gebruiken. => Serilog.AspNetCore package => dat is in de program.cs 
    })
    .UseSerilog().RunConsoleAsync();
}
catch (Exception ex)
{
    Log.Fatal(ex, "The Worker Service crashed.");
}
finally
{
    Log.CloseAndFlush();
}


/*.Net 6

    try
{
    builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console()
    .WriteTo.Seq(Environment.GetEnvironmentVariable("SEQ_URL").CoalesceTo(Resources.DefaultSeqUrl)));
}
catch (Exception ex)
{
    Log.Fatal(ex, "The Worker Service crashed.");
}
finally
{
    Log.CloseAndFlush();
}

 
 
 app.UseSerilogRequestLogging()

 */



Console.WriteLine("Hello, World!");
