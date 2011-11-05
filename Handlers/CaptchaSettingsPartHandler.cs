
using JetBrains.Annotations;
using Orchard.Captcha.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace Orchard.Captcha.Handlers
{
    [UsedImplicitly]
    public class CaptchaSettingsPartHandler : ContentHandler
    {
        public CaptchaSettingsPartHandler(IRepository<CaptchaSettingsPartRecord> repository)
        {
            Filters.Add(new ActivatingFilter<CaptchaSettingsPart>("Site"));
            Filters.Add(StorageFilter.For(repository));
        }
    }
}