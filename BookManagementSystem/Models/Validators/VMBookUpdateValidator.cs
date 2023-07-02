using BookManagementSystem.Models.ViewModel.Book;
using FluentValidation;

namespace BookManagementSystem.Models.Validators
{
	public class VMBookUpdateValidator : AbstractValidator<VMBookUpdate>
	{
		public VMBookUpdateValidator() 
		{
			RuleFor(x=>x.Book.Name).NotEmpty().MinimumLength(3).MaximumLength(100);

			RuleFor(x=>x.Book.PageCount).NotEmpty();
			RuleFor(x=>x.Book.PageCount).GreaterThan(10);

			RuleFor(x=>x.Book.PublicationDate).NotEmpty();
		}
	}
}
