using DoctorAppointment.Configuration;
using DoctorAppointment.Data;
using DoctorAppointment.Data.Implementation;
using DoctorAppointment.Data.Repositories;
using DoctorAppointment.Data.Repositories.Implementation;
using DoctorAppointment.Models.Data.Repositories;
using DoctorAppointment.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAppointment
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
            services.AddDbContext<MyContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("MyContext")));
            services.AddRazorPages();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // set the session timeout
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            //   services.AddControllersWithView();
            services.AddScoped<IDepartmentRepository, DepartmentAll>();
            services.AddScoped<IAppointment, AppointmentAll>();
            services.AddScoped<IDoctorInfo, DoctorInfoAll>();
            services.AddScoped<IPatientInfo, PatientAll>();
            services.AddScoped<IUserLogin, UserLoginAll>();
            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings")); //Connect krwaya jason or email class ko 
            services.AddTransient<IMailService, MailServices>();
            // Add authorization services
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", policy =>
                    policy.RequireRole("Admin"));
                options.AddPolicy("DoctorOnly", policy =>
                    policy.RequireRole("Doctor"));
                options.AddPolicy("PatientOnly", policy =>
                    policy.RequireRole("Patient"));
            });
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });
            });
           
        }
    }
}
