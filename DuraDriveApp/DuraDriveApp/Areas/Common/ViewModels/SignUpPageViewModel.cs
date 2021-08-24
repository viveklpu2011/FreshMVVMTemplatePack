using System;
using System.Threading.Tasks;
using DuraDriveApp.Services.Interfaces;
using DuraDriveApp.ViewModels;

namespace DuraDriveApp.Areas.Common.ViewModels
{
    public class SignUpPageViewModel : AppBaseViewModel
    {
        INavigationService _navigationService;
        public SignUpPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        internal async Task InitilizeData()
        {
            
        }
    }
}
