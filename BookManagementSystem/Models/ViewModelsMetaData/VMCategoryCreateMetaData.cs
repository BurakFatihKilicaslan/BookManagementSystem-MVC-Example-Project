using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models.ViewModelsMetaData
{
	public class VMCategoryCreateMetaData
	{
		[Required(ErrorMessage = "Cannot be empty")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The name must be a minimum of 2 characters and a maximum of 100 characters.")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Cannot be empty")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "The name must be a minimum of 5 characters and a maximum of 100 characters.")]
        public string Description { get; set; }
	}
}
