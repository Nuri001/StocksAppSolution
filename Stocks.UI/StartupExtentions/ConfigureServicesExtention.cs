using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories;
using RepositoryContracts;
using ServiceContracts.FinnhubService;
using ServiceContracts.StocksService;
using Services.FinnhubService;
using Services.StocksService;
using StocksApp.Middleware;

namespace StocksApp
{
    public static class ConfigureServicesExtention
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {

            //Services
            services.AddControllersWithViews();
            services.Configure<TradingOptions>(configuration.GetSection("TradingOptions"));
            services.AddTransient<IBuyOrdersService, StocksBuyOrdersService>();
            services.AddTransient<ISellOrdersService, StocksSellOrdersService>();
            services.AddTransient<IFinnhubCompanyProfileService, FinnhubCompanyProfileService>();
            services.AddTransient<IFinnhubStockPriceQuoteService, FinnhubStockPriceQuoteService>();
            services.AddTransient<IFinnhubStocksService, FinnhubStocksService>();
            services.AddTransient<IFinnhubSearchStocksService, FinnhubSearchStocksService>();
            services.AddTransient<IStocksRepository, StocksRepository>();
            services.AddTransient<IFinnhubRepository, FinnhubRepository>();

            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddHttpLogging(options =>
            {
                options.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.RequestProperties | Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.ResponsePropertiesAndHeaders;
            });

            services.AddHttpClient();

			services.AddTransient<ExceptionHandlingMiddleware>();


			return services;

        }
    }
}
