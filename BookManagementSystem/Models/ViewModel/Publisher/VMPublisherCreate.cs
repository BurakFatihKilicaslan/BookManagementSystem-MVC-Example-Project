using BookManagementSystem.Models.ViewModelsMetaData;
using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models.ViewModel.Publisher
{
	[MetadataType(typeof(VMPublisherCreateMetaData))]
	public class VMPublisherCreate
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public DateTime FoundationDate { get; set; }
	}
}
