
using FreshMvvm;
using DuraDriveApp.Areas.Common.ViewModels;
using DuraDriveApp.Services;

namespace DuraDriveApp.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {

        }
        static ViewModelLocator()
        {

        }
        public CurrentUser CurrentUser => FreshIOC.Container.Resolve<CurrentUser>();
        public AppShellViewModel AppShell => FreshIOC.Container.Resolve<AppShellViewModel>();
        public LoginPageViewModels LoginPage => FreshIOC.Container.Resolve<LoginPageViewModels>();
        
        public SignUpPageViewModel SignUpPage => FreshIOC.Container.Resolve<SignUpPageViewModel>();

    }
}
