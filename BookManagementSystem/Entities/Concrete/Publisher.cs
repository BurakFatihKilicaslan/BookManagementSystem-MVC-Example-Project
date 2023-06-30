using BookManagementSystem.Entities.Abstract;

namespace BookManagementSystem.Entities.Concrete
{
	public class Publisher : Base
	{
		public Publisher() 
		{
			Books = new List<Book>();
		}
		public string Address { get; set; }
		public string Phone { get; set; } 
		public DateTime FoundationDate { get; set; }
		//Relations
		public ICollection<Book> Books { get; set;}
	}
}
