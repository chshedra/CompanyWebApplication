using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyWebApplication.Domain;
using CompanyWebApplication.Domain.Repositories.Abstract;
using CompanyWebApplication.Domain.Repositories.EntityFramework;
using CompanyWebApplication.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyWebApplication
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			Configuration.Bind("Project", new Config());

			services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
			services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
			services.AddTransient<DataManager>();

			services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

			services.AddIdentity<IdentityUser, IdentityRole>(opts =>
			{
				opts.User.RequireUniqueEmail = true;
				opts.Password.RequiredLength = 6;
				opts.Password.RequireNonAlphanumeric = false;
				opts.Password.RequireLowercase = false;
				opts.Password.RequireUppercase = false;
				opts.Password.RequireDigit = false;
			}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

			services.ConfigureApplicationCookie(options =>
			{
				options.Cookie.Name = "myCompanyAuth";
				options.Cookie.HttpOnly = true;
				options.LoginPath = "/account/login";
				options.AccessDeniedPath = "/account/accessdenied";
				options.SlidingExpiration = true;
			});

			services.AddAuthorization(x =>
			{
				x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
			});

			services.AddControllersWithViews(x =>
			{
				x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
			}).SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();

			services.AddControllersWithViews().
				SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			

			app.UseStaticFiles();

			app.UseRouting();
			 
			app.UseCookiePolicy();
			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
				endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
