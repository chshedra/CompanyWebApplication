using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyWebApplication.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebApplication.Models.ViewComponents
{
	public class SidebarViewComponent : ViewComponent
	{
		private readonly DataManager _dataManager;

		public SidebarViewComponent(DataManager dataManager)
		{
			_dataManager = dataManager;
		}

		public Task<IViewComponentResult> InvokeAsync()
		{
			return Task.FromResult((IViewComponentResult) View("Default", _dataManager.ServiceItems.GetServiceItems()));
		}
	}
}
