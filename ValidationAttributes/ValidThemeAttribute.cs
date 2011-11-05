using System.ComponentModel.DataAnnotations;

namespace Orchard.Captcha.ValidationAttributes
{
    public class ValidThemeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var stringToValidate = ((string)value).ToLower();
            return stringToValidate.Equals("red") || stringToValidate.Equals("white") || stringToValidate.Equals("blackglass") || stringToValidate.Equals("clean") || stringToValidate.Equals("custom");
        }
    }
}