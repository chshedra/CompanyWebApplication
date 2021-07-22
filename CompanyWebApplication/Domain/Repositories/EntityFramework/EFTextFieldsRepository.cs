using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyWebApplication.Domain.Entities;
using CompanyWebApplication.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CompanyWebApplication.Domain.Repositories.EntityFramework
{
	public class EFTextFieldsRepository : ITextFieldsRepository
	{
		private readonly AppDbContext _context;
		public EFTextFieldsRepository(AppDbContext context)
		{
			_context = context;
		}

		public IQueryable<TextField> GetTextFields()
		{
			return _context.TextFields;
		}

		public TextField GetTextFieldById(Guid id)
		{
			return _context.TextFields.FirstOrDefault(x => x.Id == id);
		}

		public TextField GetTextFieldByCodeWord(string codeWord)
		{
			return _context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
		}

		public void SaveTextField(TextField entity)
		{
			_context.Entry(entity).State = entity.Id == default 
				? EntityState.Added : 
				EntityState.Modified;

			_context.SaveChanges();
		}

		public void DeleteTextField(Guid id)
		{
			_context.TextFields.Remove(new TextField() { Id = id });
			_context.SaveChanges();
		}
	}
}