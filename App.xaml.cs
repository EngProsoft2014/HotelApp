using EngHotel.Pages.Shared;
using EngHotel.Constants;

namespace EngHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(ApiConstants.syncFusionLicence);

            MainPage = new LoginPage();
        }
    }
}
