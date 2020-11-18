using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TesteAPI.ContextoDeDados;
using TesteAPI.Interfaces;
using TesteAPI.Model;
using TesteAPI.Repository;

namespace TesteAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<ContextAPI>(options => options.UseSqlServer(Configuration.GetConnectionString("ConexaoSirp")));
            services.AddDbContext<ContextCatmas>(options => options.UseSqlServer(Configuration.GetConnectionString("ConexaoCatmas")));
            services.AddScoped<IAtaRepository, AtaRepository>();
            services.AddScoped<IItemAtaRepository, ItemAtaRepository>();
            services.AddScoped<IItemCatalogoRepository, ItemCatalogoRepository>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
