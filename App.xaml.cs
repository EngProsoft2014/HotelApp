using EngHotel.Pages.Shared;
using EngHotel.Constants;
using EngHotel.ViewModels.Shared;
using TripBliss.Helpers;


namespace EngHotel
{
    public partial class App : Application
    {

        #region Services
        IGenericRepository Rep;
        readonly Services.Data.ServicesService _service;
        #endregion
        public App(IGenericRepository generic, Services.Data.ServicesService service)
        {
            #region Prop
            _service = service;
            Rep = generic; 
            int UserId = Preferences.Default.Get(ApiConstants.userid , 0);
            string Email = Preferences.Default.Get(ApiConstants.email , "");
            #endregion

            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(ApiConstants.syncFusionLicence);
            if (UserId != 0 && !string.IsNullOrEmpty(Email))
            {
                var vm = new HomeViewModel(Rep, _service);
                var page = new HomePage(Rep, _service);
                page.BindingContext = vm;
                MainPage = new NavigationPage(page);
            }
            else
            {
                var vm = new OnBordingViewModel(Rep, _service);
                var page = new OnBordingPage();
                page.BindingContext = vm;
                MainPage = new NavigationPage(page);
            }
        }

    }
}
