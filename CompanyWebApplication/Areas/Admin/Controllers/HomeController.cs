using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyWebApplication.Domain;

namespace CompanyWebApplication.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HomeController : Controller
	{
		private readonly DataManager _dataManager;

		public HomeController(DataManager dataManager)
		{
			_dataManager = dataManager;
		}

		public IActionResult Index()
		{
			return View(_dataManager.ServiceItems.GetServiceItems());
		}
	}
}
