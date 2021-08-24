using System;
using System.Threading.Tasks;
using DuraDriveApp.Services.Interfaces;
using DuraDriveApp.ViewModels;
using MvvmHelpers.Commands;
using MvvmHelpers.Interfaces;

namespace DuraDriveApp.Areas.Common.ViewModels
{
    public class LoginPageViewModels : AppBaseViewModel
    {
        INavigationService _navigationService;
        public IAsyncCommand RegisterCommand { get; set; }
        public LoginPageViewModels(INavigationService navigationService)
        {
            _navigationService = navigationService;
            RegisterCommand = new AsyncCommand(RegisterCommandExecute);
        }

        private async Task RegisterCommandExecute()
        {
            if (_navigationService.GetCurrentPageViewModel() != typeof(SignUpPageViewModel))
            {
                await _navigationService.NavigateToAsync<SignUpPageViewModel>();
                await App.Locator.SignUpPage.InitilizeData();
            }
        }

        public async Task InitilizeData()
        {
            //LoginEmail = string.Empty;
            //LoginPassword = string.Empty;
        }
    }
}
