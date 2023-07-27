//namespace SelfieBurguer
//{
//    public class Startup : IStartup
//    {
//        public IConfiguration Configuration { get; }
        
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }
        
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddControllers();
//            services.AddEndpointsApiExplorer();
//            services.AddSwaggerGen();
//        }

//        public void Configure(WebApplication app, IWebHostEnvironment environment)
//        {
//            if (environment.IsDevelopment())
//            {
//                app.UseSwagger();
//                app.UseSwaggerUI();
//            }

//            app.UseHttpsRedirection();
//            app.UseAuthorization();
//            app.MapControllers();
//        }
//    }

//    public interface IStartup
//    {
//        IConfiguration Configuration { get; }
//        void Configure(WebApplication app, IWebHostEnvironment environment);
//        void ConfigureServices(IServiceCollection services);
//    }

//    public static class StartupExtensions
//    {
//        public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder WebAppBuilder) where TStartup : IStartup
//        {
//            var startup = Activator.CreateInstance(typeof(IStartup), WebAppBuilder.Configuration) as IStartup;

//            if (startup == null) throw new ArgumentException("Classe Startup.cs inválida!");

//            startup.ConfigureServices(WebAppBuilder.Services);

//            var app = WebAppBuilder.Build();

//            startup.Configure(app, app.Environment);

//            app.Run();

//            return WebAppBuilder;
//        }
//    }
//}

using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SelfieBurguer.Infrastructure.CrossCutting.IOC;
using SelfieBurguer.Infrastructure.Data;

namespace SelfieBurguer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration["SqlConnection:SqlConnectionString"];
            services.AddDbContext<SqlContext>(options => options.UseSqlServer(connection));
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup).Assembly);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Selfie Burguer", Version = "v1" });
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ModuleIOC());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Selfie Burguer");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
