using BookManagementSystem.Entities.Abstract;

namespace BookManagementSystem.Entities.Concrete
{
	public class Book : Base
	{
		public int PageCount { get; set; }
		public DateTime PublicationDate { get; set; }

		//Relations
		public int? AuthorID { get; set; }
		public Author? Author { get; set; }

		public int? PublisherID { get; set; }
		public Publisher? Publisher { get; set; }

		public int? CategoryID { get; set; }
		public Category? Category { get; set; }
	}
}
