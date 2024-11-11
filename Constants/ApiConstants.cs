using System;
using System.Collections.Generic;
using System.Text;


namespace EngHotel.Constants
{
    public class ApiConstants
    {
        public static string BaseApiUrl;

        //public const string syncFusionLicence = "Ngo9BigBOggjHTQxAR8/V1NCaF1cWWhIfkxwWmFZfVpgfF9GZ1ZUTGYuP1ZhSXxXdkxhWn5Xc3BQRmVbUUE="; //Version= 24.x.x
        public const string syncFusionLicence = "Ngo9BigBOggjHTQxAR8/V1NDaF5cWWtCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXZcc3VcRWldUkN0V0Y="; //Version= 27.x.x


        #region Preferences Keys
        // Preferences Key
        public static string userid = "userid";
        public static string email = "email";
        public static string password = "password";
        public static string PINNumber = "PINNumber";
        public static string Role = "Role"; 
        public static string Type = "Type"; //1 = Guest , 2 = User 

        public static string distributorCompanyId = "distributorCompanyId";
        public static string permissions = "permissions";
        public static string review = "review";
        //End Preferences Key 
        #endregion

        #region Login & Register Api
        // Login Api
        public static string LoginApi = "api/Users/Login?";
        // Login by Pin Number Api
        public static string LoginByPinApi = "api/Users/LoginUsingPINNumber?";
        // End Login Api

        // Register Api 
        public static string RegisterApi = "api/Users";
        // End Register Api 
        #endregion

        #region Service Apis
        // AllSevices Api
        public static string GetAllSevicesApi = "api/Service";
        // End AllSevices Api

        #endregion

        #region Rooms Api
        // Room Filter Api
        public static string GetRoomFilterApi = "api/Rooms/GetAllAvailableRooms";
        // End Room Filter Api

        // Room Booking Api
        public static string RoomBookingApi = "api/Booking";
        // End Room Booking Api 
        #endregion

    }
}

