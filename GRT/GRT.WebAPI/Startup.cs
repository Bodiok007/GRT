using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using GRT.BLL.Mappers;
using GRT.Logger.Managers;
using GRT.Logger.Loggers;
using GRT.Logger.Interfaces;
using GRT.DAL.Repositories.Base;
using System;
using GRT.DAL.Models.Tokens;
using GRT.DAL.Repositories.EF.Tokens;
using Microsoft.EntityFrameworkCore;
using GRT.DAL.Contexts;
using CustomILogger = GRT.Logger.Interfaces.ILogger;

namespace GRT.WebAPI
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsEnvironment("Development"))
            {
                // This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
                builder.AddApplicationInsightsSettings(developerMode: true);
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddApplicationInsightsTelemetry(Configuration);

            services.AddMvc();

            services.AddSingleton(AutoMapperConfig.Configure());
            services.AddSingleton<CustomILogger, Log4netLogger>();
            services.AddSingleton<ILoggerManager, Log4netLoggerManager>();
            services.AddSingleton<BaseCRUDRepository<TokenDal, Int32>, TokenRepository>();
            services.AddSingleton<DbContext, GrtContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseApplicationInsightsRequestTelemetry();

            app.UseApplicationInsightsExceptionTelemetry();

            app.UseMvc();
        }
    }
}
