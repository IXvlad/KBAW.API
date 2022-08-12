using Autofac;
using KBAW.API.Infrastructure;
using KBAW.Container;
using KBAW.DataAccess.ApplicationDb;
using KBAW.ErrorHandler;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Serilog;

namespace KBAW.API;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = nameof(API), Version = "v1" }); });
        services.AddDbContext<ApplicationDbContext>(
            options =>
                options.UseSqlServer(
                    _configuration.GetSection("Database").GetConnectionString("Default")));

        services.AddAutoMapper(typeof(Startup), typeof(AutoMapperProfile));

        services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
        });
    }

    public void ConfigureContainer(ContainerBuilder containerBuilder)
    {
        containerBuilder.RegisterModule(new RegistrationModule());
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", nameof(API) + "v1"));
        }

        app.UseSerilogRequestLogging();

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();

        app.UseCors();
        
        app.UseMiddleware<ErrorMiddleware>();

        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}