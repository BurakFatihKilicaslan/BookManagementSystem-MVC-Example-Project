using BookManagementSystem.Models.ViewModelsMetaData;
using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models.ViewModel.Category
{
	[MetadataType(typeof(VMCategoryCreateMetaData))]
	public class VMCategoryCreate
	{
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
