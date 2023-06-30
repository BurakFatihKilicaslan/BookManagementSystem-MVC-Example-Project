using BookManagementSystem.DAL.Repositories.Abstract;
using BookManagementSystem.DAL.Repositories.Concrete;
using BookManagementSystem.Entities.Concrete;
using BookManagementSystem.Models.ViewModel.Category;
using BookManagementSystem.Models.ViewModel.Publisher;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IPublisherRepository publisherRepository;
        public PublisherController(IPublisherRepository publisherRepository)
        {
            this.publisherRepository = publisherRepository;
        }
        public IActionResult List()
        {
            IEnumerable<Publisher> publishers = publisherRepository.GetAll().ToList();
            return View(publishers);
        }
        public IActionResult Detail(int id)
        {
            Publisher publisher = publisherRepository.GetByIDIncludeBooks(id);
            return View(publisher);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(VMPublisherCreate create)
        {
            if (ModelState.IsValid)
            {
                Publisher publisher = new();
                publisher.Name = create.Name;
                publisher.Address = create.Address;
                publisher.Phone = create.Phone;
                publisher.FoundationDate = create.FoundationDate;
                bool IsAdded = publisherRepository.Add(publisher);
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
            Publisher publisher = publisherRepository.GetById(id);
            return View(publisher);
        }
        [HttpPost]
        public IActionResult Delete2(int id)
        {
            Publisher publisher = publisherRepository.GetById(id);
            bool IsDeleted = publisherRepository.Delete(publisher);
            if (IsDeleted)
            {
                TempData["InfoDeleted"] = "Deletion performed";
                return RedirectToAction("List");
            }
            else
            {
                TempData["Info"] = "Could Not Be Deleted";
                return RedirectToAction("Delete", publisher);
            }
        }

        public IActionResult Update(int id)
        {
            Publisher publisher = publisherRepository.GetById(id);
            if (publisher != null)
            {
                return View(publisher);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Update(Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                Publisher publisherUpdate = publisherRepository.GetFirstOrDefault(a => a.ID == publisher.ID);
                if (publisherUpdate != null)
                {
                    publisherUpdate.ID = publisher.ID;
                    publisherUpdate.Name = publisher.Name;
                    publisherUpdate.Address = publisher.Address;
                    publisherUpdate.Phone = publisher.Phone;
                    publisherUpdate.FoundationDate = publisher.FoundationDate;
                    bool IsUpdated = publisherRepository.Update(publisherUpdate);
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
            return View(publisher);
        }
    }
}
