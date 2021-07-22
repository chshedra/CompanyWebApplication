﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyWebApplication.Domain.Repositories.Abstract;

namespace CompanyWebApplication.Domain
{
	public class DataManager
	{
		public ITextFieldsRepository TextFields { get; set; }

		public IServiceItemsRepository ServiceItems { get; set; }

		public DataManager(ITextFieldsRepository textFields, IServiceItemsRepository serviceItems)
		{
			TextFields = textFields;
			ServiceItems = serviceItems;
		}
	}
}
