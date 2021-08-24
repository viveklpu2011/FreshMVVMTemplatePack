
using System;
using System.Diagnostics;
using FreshMvvm;
using System.Net.Http;
using DuraDriveApp.Services.Interfaces;
using DuraDriveApp.Core.Services;
using DuraDriveApp.Core.Services.Interfaces;
using DuraDriveApp.Services;
using DuraDriveApp.Areas.Common.ViewModels;

namespace DuraDriveApp.Bootstrap
{
    public class BootstrapConfig
    {
        public BootstrapConfig()
        {

        }
        public static void RegisterService()
        {
            try
            {
                FreshIOC.Container.Register<HttpClient>(new HttpClient());
            }
            catch (Exception e)
            {
                Debug.WriteLine($"already initiated ={e.Message}");
            }

            FreshIOC.Container.Register<IUserService, UserService>();
            FreshIOC.Container.Register<INavigationService, NavigationService>();
            FreshIOC.Container.Register<HttpService, HttpService>();
            FreshIOC.Container.Register<IAuthenticationService, AuthenticationService>();
            FreshIOC.Container.Register<IUserCoreService, UserCoreService>();
        }
        public static void RegisterViewModel()
        {
            FreshIOC.Container.Register<CurrentUser, CurrentUser>().AsSingleton();
            FreshIOC.Container.Register<LoginPageViewModels, LoginPageViewModels>().AsSingleton();
            FreshIOC.Container.Register<SignUpPageViewModel, SignUpPageViewModel>().AsSingleton();


        }
    }
}
