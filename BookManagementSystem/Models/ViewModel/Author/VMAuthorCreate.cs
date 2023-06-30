using BookManagementSystem.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models.ViewModel.Author
{
    [ModelMetadataType(typeof(VMAuthorCreateMetaData))]
    public class VMAuthorCreate
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
