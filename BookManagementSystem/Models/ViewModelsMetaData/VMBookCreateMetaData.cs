using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models.ViewModels
{
	public class VMBookCreateMetaData
	{
		[Required(ErrorMessage = "Cannot be empty")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The name must be a minimum of 2 characters and a maximum of 100 characters.")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Cannot be empty")]
		[Range(0, int.MaxValue, ErrorMessage = "Cannot Get Negative Value")]
		public int PageCount { get; set; }

		[Required(ErrorMessage = "Cannot be empty")]
		public DateTime PublicationDate { get; set; }
	}
}
