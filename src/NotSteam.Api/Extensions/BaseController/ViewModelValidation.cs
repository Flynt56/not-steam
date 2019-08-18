using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace NotSteam.Core.Extensions.BaseController
{
    public static class ViewModelValidation
    {
        public static void ValidateViewModel(this Api.Controllers.BaseController controller, object viewModelToValidate)
        {
            var validationContext = new ValidationContext(viewModelToValidate, null, null);
            var validationResults = new List<ValidationResult>();

            Validator.TryValidateObject(viewModelToValidate, validationContext, validationResults, true);

            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError(validationResult.MemberNames.FirstOrDefault() ?? string.Empty, validationResult.ErrorMessage);
            }
        }
    }
}
