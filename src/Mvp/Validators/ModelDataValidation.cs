using System.ComponentModel.DataAnnotations;
namespace Mvp.Validators
{
    public class ModelDataValidation
    {
        public void Validate(object model)
        {
            IList<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);

            string errorMessage = string.Empty;
            bool isValid = Validator.TryValidateObject(model, context, results, true);

            if (!isValid)
            {
                foreach (var item in results)
                    errorMessage += $"- {item.ErrorMessage} \n";
                throw new Exception(errorMessage);
            }
        }
    }
}