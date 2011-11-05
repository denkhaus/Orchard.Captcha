using System.ComponentModel.DataAnnotations;
using Orchard.Captcha.ValidationAttributes;
using Orchard.ContentManagement;

namespace Orchard.Captcha.Models
{
    public class CaptchaSettingsPart : ContentPart<CaptchaSettingsPartRecord>
    {
        [Required]
        public string PublicKey
        {
            get { return Record.PublicKey; }
            set { Record.PublicKey = value; }
        }

        [Required]
        public string PrivateKey
        {
            get { return Record.PrivateKey; }
            set { Record.PrivateKey = value; }
        }

        [Required]
        [ValidTheme]
        public string Theme
        {
            get { return Record.Theme; }
            set { Record.Theme = value; }
        }

        public string CustomCaptchaMarkup
        {
            get { return Record.CustomCaptchaMarkup; }
            set { Record.CustomCaptchaMarkup = value; }
        }
    }
}