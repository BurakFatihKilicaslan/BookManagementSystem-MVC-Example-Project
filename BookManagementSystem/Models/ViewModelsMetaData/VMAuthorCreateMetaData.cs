using BookManagementSystem.Models.ViewModelsMetaData.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models.ViewModels
{
	public class VMAuthorCreateMetaData
	{
		[Required(ErrorMessage = "Cannot be empty")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "The name must be a minimum of 3 characters and a maximum of 100 characters.")]
        public string Name { get; set; }

		[BirthDateRange]
		public DateTime BirthDate { get; set; }

	}
}
