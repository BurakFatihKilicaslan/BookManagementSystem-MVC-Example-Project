using BookManagementSystem.Entities.Abstract;

namespace BookManagementSystem.Entities.Concrete
{
	public class Author : Base
	{
		public Author() 
		{
			Books = new List<Book>();
		}
		public DateTime BirthDate { get; set; }
		public DateTime? DeathDate { get; set; }
		//Relations
		public ICollection<Book> Books { get; set;}
	}
}
