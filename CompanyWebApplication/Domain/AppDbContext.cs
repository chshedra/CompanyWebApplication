using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyWebApplication.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CompanyWebApplication.Domain
{
	public class AppDbContext : IdentityDbContext<IdentityUser>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<TextField> TextFields { get; set; }
		public DbSet<ServiceItem> ServiceItems { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
			{
				Id = "2cbf83b6-9352-4e6e-a796-65efb6bef16a",
				Name = "admin",
				NormalizedName = "ADMIN"
			});

			modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
			{
				Id = "65e98e27-41c1-4634-bb3e-3f966fe82a96",
				UserName = "admin",
				NormalizedUserName = "ADMIN",
				Email = "my@mail.com",
				NormalizedEmail = "MY@MAIL.COM",
				EmailConfirmed = true,
				PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
				SecurityStamp = string.Empty

			});

			modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
			{
				RoleId = "2cbf83b6-9352-4e6e-a796-65efb6bef16a",
				UserId = "65e98e27-41c1-4634-bb3e-3f966fe82a96"
			});

			modelBuilder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("dab12e73-e4c1-4207-bc94-bd8f657dd913"),
				CodeWord = "PageIndex",
				Title = "Главная"
			});

			modelBuilder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("1ca882d6-fc16-4197-a45b-c50aec7c822f"),
				CodeWord = "PageServices",
				Title = "Наши услуги"
			});

			modelBuilder.Entity<TextField>().HasData(new TextField
			{
				Id = new Guid("b6689990-6043-4bb4-85e7-586c649f1247"),
				CodeWord = "PageContacts",
				Title = "Контакты"
			});
		}
	}
}
