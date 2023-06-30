using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models.ViewModelsMetaData
{
	public class VMPublisherCreateMetaData
	{
		[Required(ErrorMessage = "Cannot be empty")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The name must be a minimum of 1 characters and a maximum of 100 characters.")]

        [Range(1, 100, ErrorMessage = "Minimum 2 Maksimum 100 Karakter Girebilirsiniz")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Cannot be empty")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "The name must be a minimum of 5 characters and a maximum of 100 characters.")]
		public string Address { get; set; }

		[Required(ErrorMessage = "Cannot be empty")]
        [StringLength(15, MinimumLength = 9, ErrorMessage = "The name must be a minimum of 10 characters and a maximum of 15 characters.")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Cannot be empty")]
		public DateTime FoundationDate { get; set; }
	}
}
