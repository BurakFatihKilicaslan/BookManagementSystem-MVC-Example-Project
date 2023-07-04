using BookManagementSystem.Models.ViewModel.Book;
using FluentValidation;

namespace BookManagementSystem.Models.Validators
{
	public class VMBookCreateValidator : AbstractValidator<VMBookCreate>
	{
		public VMBookCreateValidator() 
		{
			RuleFor(x => x.Book.Name).NotEmpty();
			RuleFor(x => x.Book.Name).MinimumLength(3);
			RuleFor(x => x.Book.Name).MaximumLength(100);

			RuleFor(x => x.Book.PageCount).NotEmpty();
			RuleFor(x => x.Book.PageCount).GreaterThan(10);

			RuleFor(x => x.Book.PublicationDate).NotEmpty();
		}
	}
}
