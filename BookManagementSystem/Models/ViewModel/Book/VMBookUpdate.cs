using BookManagementSystem.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookManagementSystem.Models.ViewModel.Book
{
    public class VMBookUpdate
    {
        public BookManagementSystem.Entities.Concrete.Book Book { get; set; }
        public SelectList? Categories { get; set; }
        public SelectList? Publishers { get; set; }
        public SelectList? Authors { get; set; }
    }
}
