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
            
            displayName = attributes != null ? 
                (attributes[0] as DisplayNameAttribute).DisplayName : 
                validationContext.DisplayName;

            return base.IsValid(value, validationContext);
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, displayName.SplitCamelCase());
        }
    }
}
