using System;
using System.Collections.Generic;
using DuraDriveApp.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveApp.Areas.Common.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : IRootView, IMainView
    {
        public LoginPage()
        {
            InitializeComponent();
            App.Locator.LoginPage.InitilizeData();
        }
    }
}
