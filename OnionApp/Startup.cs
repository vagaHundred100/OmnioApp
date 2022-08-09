using BLL.Autorization;
using BLL.Autorization.Abstract;
using BLL.Autorization.Concrete;
using BLL.Helpers.Dependencis;
using BLL.Helpers.ExeotionHandler;
using BLL.Services.Abstract;
using BLL.Services.Concrete;
using DAL.Context;
using DAL.Domains;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using OnionApp.SWAGER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using System.Security.Claims;
using DAL.Repositories.Abstract;
using DAL.Repositories.Concrete;

namespace OnionApp
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

            services.AddControllers();
            services.AddSwagerSettings();

            services.Configure<JWTOptions>(Configuration.GetSection("JWTOptions"));
            JWTOptions jwtSettings = Configuration.GetSection("JWTOptions").Get<JWTOptions>();
            services.AuthenticationJwtSettings(jwtSettings);
            services.SetBLLDependensis();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IChatBoxRepository, ChatBoxRepository>();


            string conn = Configuration.GetConnectionString("Default");
            services.AddDbContext<OnionDbContext>(options => options.UseSqlServer(conn ,b => b.MigrationsAssembly("OnionApp")));

            services.AddIdentity<User, IdentityRole>()
                    .AddEntityFrameworkStores<OnionDbContext>();

            services.AddAuthorization(opts =>
            {
                opts.AddPolicy("OnlyForActive", policy =>
                 {
                     policy.RequireClaim("isEnabled", "True");
                 });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OnionApp v1"));
            }

            app.UseMiddleware<ErrorHandlerMiddleware>();

            //app.UseSerilogRequestLogging();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
