using System;
using System.Data;
using System.IO;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Serilog;
using MMS.Infrastructure.Data;
using MMS.Application.Services;
using MMS.Presentation.ViewModels;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Serilog.Extensions.Logging;

namespace Presentation
{
    public partial class App : Application
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        public static IConfiguration? Configuration { get; private set; }

        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddUserSecrets<App>(); // Dodaj User Secrets
            Configuration = configBuilder.Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .WriteTo.File("logs/app.log", rollingInterval: Serilog.RollingInterval.Day)
                .CreateLogger();

            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IAuthService, AuthService>();
            services.AddTransient<LoginViewModel>();
            services.AddTransient<ShellViewModel>();

            // Registracija u DI
            //services.AddScoped<DatabaseConnector>();

            services.AddSingleton<IDbConnectionFactory>(sp =>
            {
                var cfg = sp.GetRequiredService<IConfiguration>();
                var cs = cfg.GetConnectionString("DefaultConnection");
                if (string.IsNullOrWhiteSpace(cs))
                    throw new InvalidOperationException("Connection string 'DefaultConnection' is missing or empty.");
                return new SqlConnectionFactory(cs);
            });

            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.AddSerilog(Log.Logger, dispose: true);
            });

            ServiceProvider = services.BuildServiceProvider();

            /*var dbConnector = ServiceProvider.GetRequiredService<DatabaseConnector>();
            try
            {
                var healthOk = await dbConnector.HealthCheckAsync();
                if (!healthOk)
                {
                    MessageBox.Show("Neuspešna konekcija sa bazom!\nDetalji su u logs/app.log.", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    // Dodaj ovu liniju za potvrdu uspešne konekcije
                    MessageBox.Show("Konekcija sa bazom je uspešno uspostavljena.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    Log.Information("Konekcija sa bazom je uspešno uspostavljena.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri konekciji: {ex.Message}", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            }*/

            AppDomain.CurrentDomain.UnhandledException += (s, args) =>
            {
                Log.Error(args.ExceptionObject as Exception, "Neuhvaćena greška");
                MessageBox.Show("Došlo je do greške u aplikaciji.", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            };

            this.DispatcherUnhandledException += (s, args) =>
            {
                Log.Error(args.Exception, "Greška u UI threadu");
                MessageBox.Show("Došlo je do greške u aplikaciji.", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                args.Handled = true;
            };

            // Ova sekcija je dodatak iz novog koda
            // Provera konekcije s bazom pri pokretanju aplikacije
            var serviceProvider = App.ServiceProvider;
            var logger = serviceProvider.GetRequiredService<Microsoft.Extensions.Logging.ILogger<App>>();
            var db = serviceProvider.GetRequiredService<AppDbContext>();

            bool dbOk = await db.HealthCheckAsync(logger);
            if (!dbOk)
            {
                MessageBox.Show("Neuspešna konekcija na bazu! Proverite konfiguraciju.", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                Shutdown();
            }
        }
    }
}