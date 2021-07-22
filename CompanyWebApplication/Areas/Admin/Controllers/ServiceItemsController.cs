using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CompanyWebApplication.Domain;
using CompanyWebApplication.Domain.Entities;
using CompanyWebApplication.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace CompanyWebApplication.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ServiceItemsController : Controller
	{
		private readonly DataManager _dataManager;
		private readonly IWebHostEnvironment _hostingEnvironment;

		public ServiceItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
		{
			_dataManager = dataManager;
			_hostingEnvironment = hostingEnvironment;
		}

		public IActionResult Edit(Guid id)
		{
			var entity = id == default
				? new ServiceItem()
				: _dataManager.ServiceItems.GetServiceItemById(id);

			return View(entity);
		}

		[HttpPost]
		public IActionResult Edit(ServiceItem model, IFormFile titleImageFile)
		{
			if (ModelState.IsValid)
			{
				if (titleImageFile != null)
				{
					model.TitleImagePath = titleImageFile.FileName;
					using (var stream = new FileStream(Path.Combine(_hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), 
						FileMode.Create))
					{
						titleImageFile.CopyTo(stream);
					}

					_dataManager.ServiceItems.SaveServiceItem(model);

					return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
				}
			}
			return View(model);
		}

		[HttpPost]
		public IActionResult Delete(Guid id)
		{
			_dataManager.ServiceItems.DeleteServiceItem(id);
			return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
		}
	}
}
