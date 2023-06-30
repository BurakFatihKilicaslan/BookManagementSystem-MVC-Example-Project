using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models.ViewModelsMetaData.CustomValidations
{
    public class BirthDateRange : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            DateTime birthDate = (DateTime)value;

            // İstenilen doğum tarihi aralığına göre kısıtlama yapabilirsiniz
            DateTime minDate = new DateTime(1, 1, 1);
            DateTime maxDate = DateTime.Now;

            if (birthDate >= minDate && birthDate <= maxDate)
            {
                return true;
            }
            else
            {
                ErrorMessage = "Make sure that the entered date information is correct.";
                return false;
            }

        }
    }
}
