using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Asp.netCoreMVCCRUD.Classes
{
    public class RequiredAttribute : System.ComponentModel.DataAnnotations.RequiredAttribute
    {
        private string displayName;

        public RequiredAttribute()
        {
            ErrorMessage = "{0} is required";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var attributes = validationContext.ObjectType
                .GetProperty(validationContext.MemberName)
                .GetCustomAttributes(typeof(DisplayNameAttribute), true);
            
            displayName = (attributes[0] as DisplayNameAttribute)?.DisplayName;

            return base.IsValid(value, validationContext);
        }

        public override string FormatErrorMessage(string name) => string.Format(ErrorMessageString, displayName.SplitCamelCase());
    }
}
