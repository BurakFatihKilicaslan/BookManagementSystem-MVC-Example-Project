using BookManagementSystem.Entities.Abstract;

namespace BookManagementSystem.Entities.Concrete
{
	public class Category : Base
	{
		public Category() 
		{
			Books = new List<Book>();
		}
		public string Description { get; set; }
		//Relations
		public ICollection<Book> Books { get; set; }
	}
}
