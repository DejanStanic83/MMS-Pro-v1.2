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
using Domain.Common;
using MMS.Application.DTOs;

namespace Presentation
{
    /// <summary>
    /// Glavna klasa WPF aplikacije.
    /// Sadrži DI konfiguraciju, inicijalizaciju logovanja, konfiguracije i globalno rukovanje greškama.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Globalni ServiceProvider za Dependency Injection.
        /// </summary>
        public static IServiceProvider? ServiceProvider { get; private set; }

        /// <summary>
        /// Globalna konfiguracija aplikacije (učitana iz appsettings.json i UserSecrets).
        /// </summary>
        public static IConfiguration? Configuration { get; private set; }

        /// <summary>
        /// Override metoda koja se poziva pri pokretanju aplikacije.
        /// Inicijalizuje DI, logovanje, proverava konekciju sa bazom i postavlja globalne handlere za greške.
        /// </summary>
        /// <param name="e">Argumenti pokretanja aplikacije.</param>
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Inicijalizacija konfiguracije (appsettings.json + UserSecrets)
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddUserSecrets<App>(); // Dodaj User Secrets
            Configuration = configBuilder.Build();

            // Inicijalizacija Serilog logovanja
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .WriteTo.File("logs/app.log", rollingInterval: Serilog.RollingInterval.Day)
                .CreateLogger();

            // Konfiguracija Dependency Injection kontejnera
            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(Configuration);

            // Registracija DbContext-a sa SQL Server konekcijom
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Registracija servisa i view modela
            services.AddScoped<IAuthService, AuthService>();
            services.AddTransient<LoginViewModel>();
            services.AddTransient<ShellViewModel>();
            services.AddSingleton<IUserSession, UserSession>();

            // Registracija fabrike za SQL konekcije
            services.AddSingleton<IDbConnectionFactory>(sp =>
            {
                var cfg = sp.GetRequiredService<IConfiguration>();
                var cs = cfg.GetConnectionString("DefaultConnection");
                if (string.IsNullOrWhiteSpace(cs))
                    throw new InvalidOperationException("Connection string 'DefaultConnection' is missing or empty.");
                return new SqlConnectionFactory(cs);
            });

            // Konfiguracija logovanja preko Serilog-a
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.AddSerilog(Log.Logger, dispose: true);
            });

            // Registracija AutoMapper profila
            services.AddAutoMapper(typeof(UserProfile).Assembly);

            // Kreiranje ServiceProvider-a
            ServiceProvider = services.BuildServiceProvider();

            // Globalni handler za neuhvaćene greške na AppDomain nivou
            AppDomain.CurrentDomain.UnhandledException += (s, args) =>
            {
                Log.Error(args.ExceptionObject as Exception, "Neuhvaćena greška");
                MessageBox.Show("Došlo je do greške u aplikaciji.", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            };

            // Globalni handler za neuhvaćene greške u UI threadu
            this.DispatcherUnhandledException += (s, args) =>
            {
                Log.Error(args.Exception, "Greška u UI threadu");
                MessageBox.Show("Došlo je do greške u aplikaciji.", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                args.Handled = true;
            };

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