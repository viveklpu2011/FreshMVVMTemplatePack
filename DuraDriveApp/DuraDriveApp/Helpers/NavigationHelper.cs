﻿
using System;
using System.Linq;
using DuraDriveApp.ViewModels;

namespace DuraDriveApp.Helpers
{
    public class NavigationHelper : AppBaseViewModel
    {
        public static bool CheckType(Type type)
        {

            //if(NavigationService.GetCurrentPageViewModel != type)
            //{

            //}

            if (App.Current.MainPage.Navigation.NavigationStack.Count > 0)
                return App.Current.MainPage.Navigation.NavigationStack.Last().GetType() != type;
            else
                return true;
        }
    }
}
