using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyWebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebApplication.Controllers
{
	[Authorize]
	public class AccountController : Controller
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly SignInManager<IdentityUser> _signInManager;

		public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[AllowAnonymous]
		public IActionResult Login(string returnUrl)
		{
			ViewBag.returnUrl = returnUrl;
			return View(new LoginViewModel());
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
		{
			if (ModelState.IsValid)
			{
				IdentityUser user = await _userManager.FindByNameAsync(model.UserName);

				if (user != null)
				{
					await _signInManager.SignOutAsync();
					Microsoft.AspNetCore.Identity.SignInResult result =
						await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

					if (result.Succeeded)
					{
						return Redirect(returnUrl ?? "/");
					}
				}

				ModelState.AddModelError(nameof(LoginViewModel.UserName), "Неверный логин или пароль");
			}

			return View(model);
		}

		public async Task<IActionResult> LogOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
	}
}
