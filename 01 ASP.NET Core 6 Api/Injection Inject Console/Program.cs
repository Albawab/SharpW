// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Stichting.Doneren.DbContext.Read.Handler.Handles;
using Stichting.Doneren.DomeinRead.Models.Users;
using System.Text;




var services = new ServiceCollection();
ConfigureServices(services);
services
    .AddSingleton<DbContextReadHandle, DbContextReadHandle>()
    .BuildServiceProvider()
    .GetService<DbContextReadHandle>()
    .Handle();

// ================================>==================================> هون حطينا السيرفس حتا نقدر نعمل inject

static void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<Stichting.Doneren.DbContextRead.StichtingDbContextRead>(options =>
    {
        options.UseSqlServer(
            "Server=SQLDEVELOP\\SQL2017;Initial Catalog=Stichting.DonerenRead;User ID=sa;Password=Sebas0412;MultipleActiveResultSets=true",
            b => b.MigrationsAssembly(typeof(Stichting.Doneren.DbContextRead.StichtingDbContextRead).Assembly.FullName));
    });
}


/*using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
                services.AddDbContext<Stichting.Doneren.DbContextRead.StichtingDbContextRead>(options =>
                {
                    options.UseSqlServer(
                        "Server=SQLDEVELOP\\SQL2017;Initial Catalog=Stichting.DonerenRead;User ID=sa;Password=Sebas0412;MultipleActiveResultSets=true",
                        b => b.MigrationsAssembly(typeof(Stichting.Doneren.DbContextRead.StichtingDbContextRead).Assembly.FullName));
                })
                .AddSingleton<IHandleDbContextRead, DbContextReadHandler>()).Build().Services.GetService<DbContextReadHandle>().Handle();

await host.RunAsync();*/