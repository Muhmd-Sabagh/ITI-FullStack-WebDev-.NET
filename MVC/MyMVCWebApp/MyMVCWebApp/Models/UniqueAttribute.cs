using System.ComponentModel.DataAnnotations;

namespace MyMVCWebApp.Models
{
    public class UniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                return ValidationResult.Success;

            string name = value.ToString();
            Course courseEntered = (Course)validationContext.ObjectInstance;

            ITIDBContext context = (ITIDBContext)validationContext.GetService(typeof(ITIDBContext));

            if (context?.Courses.FirstOrDefault(c => c.Name == name && c.DeptId == courseEntered.DeptId) != null)
                return new ValidationResult("Name Already Exists in this Department!");
            else
                return ValidationResult.Success;
        }
    }
}
