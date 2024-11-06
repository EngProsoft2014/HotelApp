using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
//using EngHotel.Models;
using System.Threading.Tasks;
using Akavache;
using System.Reactive.Linq;
using EngHotel.Constants;
using CommunityToolkit.Maui.Alerts;
using Controls.UserDialogs.Maui;
using EngHotel.Models.UserModels;
using EngHotel.Helpers;
using TripBliss.Helpers;



namespace EngHotel.Services.Data
{
    public interface IServicesService
    {
        Task<ImageSource> AccountPhoto();
        Task<string> UserToken();
    }


    public class ServicesService : IServicesService
    {
        
        readonly IGenericRepository Rep;
        public ServicesService(IGenericRepository ORep)
        {
            Rep = ORep;
        }

        ImageSource Photo;
        string ServiceKey = "ServiceKey";

        //EmployeeModel loginModel;
        string MUserToken;
        public static string UserTokenServiceKey = "UserTokenServiceKey";

        public async Task<ImageSource> AccountPhoto()
        {
            //Photo = Controls.StaticMembers.AccountImg;
            await BlobCache.LocalMachine.InsertObject(ServiceKey, Photo, DateTimeOffset.Now.AddYears(1));
            return Photo;
        }


        public async Task<string> UserToken()
        {
            try
            {
                MUserToken = await BlobCache.LocalMachine.GetObject<string>(UserTokenServiceKey);
            }
            catch (Exception)
            {
                MUserToken = null;
            }

            if (MUserToken == null)
            {
                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {
                    if (!string.IsNullOrEmpty(Preferences.Default.Get(ApiConstants.email, "")))
                    {
                        string Pass = await App.Current!.MainPage!.DisplayPromptAsync("Info", "Your Token expired, Please Enter Your Password", "Ok");

                        UserRequest model = new UserRequest()
                        {
                            UserName = Preferences.Default.Get(ApiConstants.email, ""),
                            Password = Pass
                        };

                        UserDialogs.Instance.ShowLoading();
                        var loginModel = await Rep.PostTRAsync<UserRequest, UsersDTO>(Constants.ApiConstants.LoginApi, model);
                        UserDialogs.Instance.HideHud();

                        if (loginModel.Item1 != null)
                        {
                            MUserToken = loginModel.Item1.Token!;

                            await BlobCache.LocalMachine.InsertObject(UserTokenServiceKey, loginModel.Item1.Token!, DateTimeOffset.Now.AddMinutes(43200));

                            return loginModel.Item1.Token!;
                        }
                        else
                        {
                            var toast = Toast.Make("Password Invalid", CommunityToolkit.Maui.Core.ToastDuration.Long, 15);
                            await toast.Show();
                        }
                    }
                }
            }
            else
            {
                return MUserToken;
            }

            return MUserToken!;
        }
    }
}
