using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fiddle_digital.Areas.Admin.Controllers;
using fiddle_digital.Helpers;
using fiddle_digital.Infrustructure;
using fiddle_digital.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Swashbuckle.AspNetCore.Swagger;
using System.Reflection;
using System.IO;
using Microsoft.AspNetCore.Http.Features;

namespace fiddle_digital
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            
            services.AddCors();

            string connection = Configuration.GetConnectionString("SqlContextConnection");

            //connection to DB
            services.AddDbContext<SqlContext>(options => options.UseSqlServer(connection));

            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = int.MaxValue; // In case of multipart
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new PathString($"/admin/{nameof(AccountController).CutController()}/{nameof(AccountController.Login).ToLower()}");
                });

            services.AddTransient(t => new FileManager());
            services.AddAutoMapper();

            services.AddSwaggerGen(t =>
            {
                t.SwaggerDoc("v1", new Info { Title = "Fiddle Digital API", Version = "v1" });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                t.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == 404)
                {
                    context.Request.Path = "/home/index";
                    await next();
                }
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseCors(builder => builder.AllowAnyOrigin());
            app.UseStaticFiles();
            app.UseSwagger();

            app.UseSwaggerUI(t =>
            {
                t.SwaggerEndpoint("/swagger/v1/swagger.json", "My API");
            });

            app.UseAuthentication();

            app.UseHttpsRedirection();
            
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultList",
                    template: "{area:exists}/{controller=home}/{action=List}/{id?}");

                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=home}/{action=Index}");

                routes.MapRoute(
                    name: "uploadpdf",
                    template: "{controller=api}/{action=UploadPDF}/{id?}/");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
