using CommunityToolkit.Maui.Core;
using Controls.UserDialogs.Maui;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngHotel.Constants;
using EngHotel.Helpers;

namespace EngHotel.Controls
{
    static class StaticMember
    {
        #region Const Variables
        public static string SnackBarColor = "#2fa562";
        public static string SnackBarTextColor = "#FFFFFF";
        public static int WayOfTab { get; set; } = 0;
        public static int WayOfPhotosPopup { get; set; } = 0;
        public static bool ShowSendOfferBtn { get; set; } = false;
        public static DateTime? EndRequestStatic { get; set; }
        #endregion

        #region SnackBar Setting
        [Obsolete]
        public static async void ShowSnackBar(string Message, string BKColor, string TextColor, Action action1)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            var snackbarOptions = new SnackbarOptions
            {
                BackgroundColor = Color.FromHex(BKColor),
                TextColor = Color.FromHex(TextColor),
                ActionButtonTextColor = Color.FromHex(TextColor),
                CornerRadius = new CornerRadius(10),
                Font = Microsoft.Maui.Font.SystemFontOfSize(14),
                ActionButtonFont = Microsoft.Maui.Font.SystemFontOfSize(14),
            };
            string text = Message;
            string actionButtonText = ""; // EngHotel.Resources.Language.AppResources.OK;
            Action action = action1;
            TimeSpan duration = TimeSpan.FromSeconds(3);

            var snackbar = CommunityToolkit.Maui.Alerts.Snackbar.Make(text, action, actionButtonText, duration, snackbarOptions);

            await snackbar.Show(cancellationTokenSource.Token);
        }
        #endregion

        #region Services
        //static IGenericRepository? Rep;
        //static Services.Data.ServicesService? _service;
        #endregion

        
    }
}
