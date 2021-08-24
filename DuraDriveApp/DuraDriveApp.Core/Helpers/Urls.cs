using System;
using System.Collections.Generic;
using System.Text;

namespace DuraDriveApp.Core.Helpers
{
    public class Urls
    {
        // Base Url
        public static string BASE_URL = "https://162.241.87.160/shriek_api/api/";

        //Auth Urls
        public static string SIGN_UP_URL = "register";
        public static string RESEND_URL = "ResendOTP";
        public static string VERIFICATION_URL = "VerificationOTP";
        public static string GET_SERVICE_LEVEL_URL = "GetServiceLevel";
        public static string UPDATE_MEMBERSHIP_URL = "SelectedServicePlan";
        public static string FORGOT_URL = "ForgotPassword";
        public static string CHANGE_PASSWORD_URL = "ResetPassword";

        //User
        public static string GET_EMERGENCY_CONTACT_URL = "GetEmergencyContact";
        public static string ADD_EMERGENCY_Url = "AddEmergencyContact";
        public static string DELETE_EMERGENCY_URL = "DeleteEmergencyContact";
        public static string MY_ORDER_URL = "GetOrderedProducts";
        public static string UPDATE_PROFILE_URL = "update-customer-profile";

        //Notification
        public static string GET_NOTIFICATION_URL = "Notification";

        //Shop
        public static string GET_PRODUCTS_URL = "GetProducts";
        public static string MAKE_ORDER_URL = "MakeOrder";
        public static string CONTACT_US_URL = "ContactUs";
    }
}
