using BookManagementSystem.DAL.Repositories.Abstract;
using BookManagementSystem.DAL.Repositories.Concrete;
using BookManagementSystem.Entities.Concrete;
using BookManagementSystem.Models.ViewModel.Book;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookManagementSystem.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository bookRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IPublisherRepository publisherRepository;
        private readonly IAuthorRepository authorRepository;
        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository, IPublisherRepository publisherRepository, IAuthorRepository authorRepository)
        {
            this.bookRepository = bookRepository;
            this.categoryRepository = categoryRepository;
            this.publisherRepository = publisherRepository;
            this.authorRepository = authorRepository;
        }
        public IActionResult List()
        {
            IEnumerable<Book> books = bookRepository.GetByIDIncludeCategoryIncludeAuthorIncludePublisherAll();
            return View(books);
        }
        public IActionResult Create()
        {
            VMBookCreate create = new();
            create.Book = new Book();
            create.Categories = new SelectList(categoryRepository.GetAll(), "ID", "Name");
            create.Publishers = new SelectList(publisherRepository.GetAll(), "ID", "Name");
            create.Authors = new SelectList(authorRepository.GetAll(), "ID", "Name");

            return View(create);
        }

        [HttpPost]
        public IActionResult Create(VMBookCreate create)
        {
            if (ModelState.IsValid)
            {
                Book book = new();
                book.Name = create.Book.Name;
                book.PageCount = create.Book.PageCount;
                book.PublicationDate = create.Book.PublicationDate;
                book.CategoryID = create.Book.CategoryID;
                book.AuthorID = create.Book.AuthorID;
                book.PublisherID = create.Book.PublisherID;

                bool isAdded = bookRepository.Add(book);
                if (isAdded)
                {
                    TempData["Info"] = "Add is Complete";
                    return RedirectToAction("List");
                }
                else
                {
                    ViewBag.Info = "Add Could Not Be Completed";
                }
            }
            return View(create);
        }
        public IActionResult Delete(int id)
        {
            Book book = bookRepository.GetByIDIncludeCategoryIncludeAuthorIncludePublisherFirstOrDefault(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Delete2(int id)
        {
            Book book = bookRepository.GetById(id);
            bool IsDeleted = bookRepository.Delete(book);
            if (IsDeleted)
            {
                TempData["Info"] = "Deletion performed";
                return RedirectToAction("List");
            }
            else
            {
                TempData["InfoDeleted"] = "Could Not Be Deleted";
                return RedirectToAction("Delete", book);
            }
        }
        public IActionResult Update(int id)
        {
            VMBookUpdate update = new();
            update.Book = bookRepository.GetByIDIncludeCategoryIncludeAuthorIncludePublisherFirstOrDefault(id);
            if (update.Book != null)
            {
                update.Categories = new SelectList(categoryRepository.GetAll(), "ID", "Name");
                update.Publishers = new SelectList(publisherRepository.GetAll().ToList(), "ID", "Name");
                update.Authors = new SelectList(authorRepository.GetAll(), "ID", "Name");
                return View(update);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Update(VMBookUpdate update)
        {
            if (ModelState.IsValid)
            {
                Book bookUpdate = bookRepository.GetFirstOrDefault(a => a.ID == update.Book.ID);
                if (bookUpdate != null)
                {
                    bookUpdate.ID = update.Book.ID;
                    bookUpdate.Name = update.Book.Name;
                    bookUpdate.PageCount = update.Book.PageCount;
                    bookUpdate.PublicationDate = update.Book.PublicationDate;
                    bookUpdate.CategoryID = update.Book.CategoryID;
                    bookUpdate.AuthorID = update.Book.AuthorID;
                    bookUpdate.PublisherID = update.Book.PublisherID;
                    bool IsUpdated = bookRepository.Update(bookUpdate);
                    if (IsUpdated)
                    {
                        TempData["Info"] = "Updates Have Been Made";
                        return RedirectToAction("List");
                    }
                    else
                    {
                        ViewBag.Info = "Update Operations Failed";
                    }
                }
            }
            return View(update);
        }
    }
}
