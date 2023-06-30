using BookManagementSystem.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookManagementSystem.Models.ViewModel.Book
{
	public class VMBookCreate
	{
		public BookManagementSystem.Entities.Concrete.Book Book { get; set; }
		public SelectList? Categories { get; set; } 
        public SelectList? Publishers { get; set; }
		public SelectList? Authors { get; set; }

        //ModelState.isvalid not working when SelectList expression is not null
    }
}
