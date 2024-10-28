using EngHotel.Pages.Shared;
using EngHotel.Constants;
using EngHotel.ViewModels.Shared;

namespace EngHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(ApiConstants.syncFusionLicence);
            var vm = new OnBordingViewModel();
            var page = new OnBordingPage();
            //var vm = new BookingViewModel();
            //var page = new BookingPage();
            page.BindingContext = vm;
            MainPage = new NavigationPage(page);
        }
    }
}
