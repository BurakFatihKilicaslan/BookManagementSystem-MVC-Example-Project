using BookManagementSystem.DAL.Repositories.Abstract;
using BookManagementSystem.DAL.Repositories.Concrete;
using BookManagementSystem.Entities.Concrete;
using BookManagementSystem.Models.ViewModel.Author;
using BookManagementSystem.Models.ViewModel.Category;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult List()
        {
            IEnumerable<Category> categories = categoryRepository.GetAll().ToList();
            return View(categories);
        }
        public IActionResult Detail(int id)
        {
            Category category = categoryRepository.GetByIDIncludeBooks(id);
            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(VMCategoryCreate create)
        {
            if (ModelState.IsValid)
            {
                Category category = new();
                category.Name = create.Name;
                category.Description = create.Description;
                bool IsAdded = categoryRepository.Add(category);
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
            Category category = categoryRepository.GetById(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Delete2(int id)
        {
            Category category = categoryRepository.GetById(id);
            bool IsDeleted = categoryRepository.Delete(category);
            if (IsDeleted)
            {
                TempData["Info"] = "Deletion performed";
                return RedirectToAction("List");
            }
            else
            {
                TempData["InfoDeleted"] = "Could Not Be Deleted";
                return RedirectToAction("Delete", category);
            }
        }

        public IActionResult Update(int id)
        {
            Category category = categoryRepository.GetById(id);
            if (category != null)
            {
                return View(category);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                Category categoryUpdate = categoryRepository.GetFirstOrDefault(a => a.ID == category.ID);
                if (categoryUpdate != null)
                {
                    categoryUpdate.ID = category.ID;
                    categoryUpdate.Name = category.Name;
                    categoryUpdate.Description = category.Description;
                    bool IsUpdated = categoryRepository.Update(categoryUpdate);
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
            return View(category);
        }
    }
}
