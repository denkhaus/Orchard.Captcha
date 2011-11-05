using Orchard.Captcha.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace Orchard.Captcha.Drivers
{
    public class CaptchaSettingsDriver : ContentPartDriver<CaptchaSettingsPart>
    {
        protected override string Prefix { get { return "CaptchaSettings"; } }

        protected override DriverResult Editor(CaptchaSettingsPart part, dynamic shapeHelper)
        {
            //GET
            return ContentShape("Parts_Captcha_SiteSettings",
                                () => shapeHelper.EditorTemplate(TemplateName: "Parts.Captcha.SiteSettings",
                                                                 Model: part.Record,
                                                                 Prefix: Prefix));
        }

        //POST
        protected override DriverResult Editor(CaptchaSettingsPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part.Record, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}