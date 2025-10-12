using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CalculatorAppDB.Infrastructure
{
    // Attribute and IModelValidator inherites from VerifyFunctionsAttribute 
    public class VerifyFunctionsAttribute : Attribute, IModelValidator
    {
        public bool IsRequired => true;

        // Method to display valid values
        public string ErrorMessage { get; set; } =
            "Valid function values are: 240, 300, 315, 400, 417, 422, 552, 605, 640";

        // Valid function values
        private readonly List<int> ValidFunctions = new List<int>
        {
            240, 300, 315, 400, 417, 422, 552, 605, 640
        }; // end list

        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            //
            // Name             : IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
            // Purpose          : Validate the Functions property to ensure its value is in the allowed set
            // Re-use           : None
            // Input Parameters : ModelValidationContext context
            //                    - provides access to the model being validated
            // Output Type      : IEnumerable<ModelValidationResult>
            //                    - collection of validation results (empty if valid)
            //
            int? value = context.Model as int?;

            // Fail if null or not in the allowed set
            if (!value.HasValue || !ValidFunctions.Contains(value.Value))
            {
                return new List<ModelValidationResult>
                {
                    new ModelValidationResult("", ErrorMessage)
                };
            } // end if

            // Pass if valid
            return Enumerable.Empty<ModelValidationResult>();
        } // end Validate
    } // end class VerifyFunctionsAttribute
} // end namespace CalculatorAppDB.Infrastructure
