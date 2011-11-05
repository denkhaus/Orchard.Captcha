using Orchard.Data.Migration;

namespace Orchard.Captcha
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            // Creating table MapRecord
            SchemaBuilder.CreateTable("CaptchaSettingsPartRecord", table => table
                .ContentPartRecord()
                .Column<string>("PublicKey", c => c.NotNull())
                .Column<string>("PrivateKey", c => c.NotNull())
                .Column<string>("Theme", c => c.NotNull())
                .Column<string>("CustomCaptchaMarkup", c => c.WithLength(4000).Nullable())
            );
            return 1;
        }
    }
}