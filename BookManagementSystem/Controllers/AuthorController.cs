using BookManagementSystem.DAL.Repositories.Abstract;
using BookManagementSystem.Entities.Concrete;
using BookManagementSystem.Models.ViewModel.Author;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IRepository<Author> repository;
        private readonly IAuthorRepository authorRepository;
        public AuthorController(IRepository<Author> repository, IAuthorRepository authorRepository)
        {
            this.repository = repository;
            this.authorRepository = authorRepository;
        }

        public IActionResult ThemeView()
        {
            return View();
        }
        public IActionResult List()
        {
            IEnumerable<Author> authors = authorRepository.GetAll().ToList();
            return View(authors);
        }

        public IActionResult Detail(int id)
        {
            Author author = authorRepository.GetByIDIncludeBooks(id);
            return View(author);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(VMAuthorCreate create)
        {
            if (ModelState.IsValid)
            {
                Author author = new();
                author.Name = create.Name;
                author.BirthDate = create.BirthDate;
                author.DeathDate = null;
                bool IsAdded = authorRepository.Add(author);
                if (IsAdded)
                {
                    TempData["Info"] = "Addition Has Been Made";
                    return RedirectToAction("List");
                }
                else
                {
                    ViewBag.Info = "Could Not Be Added";
                }
            }
            return View(create);
        }

        public IActionResult Delete(int id)
        {
            Author author = authorRepository.GetById(id);
            return View(author);
        }
        [HttpPost]
        public IActionResult Delete2(int id)
        {
            Author author = authorRepository.GetById(id);
            bool IsDeleted = authorRepository.Delete(author);
            if (IsDeleted)
            {
                TempData["Info"] = "Deletion performed";
                return RedirectToAction("List");
            }
            else
            {
                TempData["InfoDeleted"] = "Could Not Be Deleted";
                return RedirectToAction("Delete", author);
            }
        }

        public IActionResult Update(int id)
        {
            Author author = authorRepository.GetById(id);
            if (author != null)
            {
                return View(author);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Update(Author author)
        {
            if (ModelState.IsValid)
            {
                Author authorUpdate = authorRepository.GetFirstOrDefault(a => a.ID == author.ID);
                if (authorUpdate != null)
                {
                    authorUpdate.ID = author.ID;
                    authorUpdate.Name = author.Name;
                    authorUpdate.BirthDate = author.BirthDate;
                    authorUpdate.DeathDate = author.DeathDate;
                    bool IsUpdated = authorRepository.Update(authorUpdate);
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
            return View(author);
        }
    }
}
