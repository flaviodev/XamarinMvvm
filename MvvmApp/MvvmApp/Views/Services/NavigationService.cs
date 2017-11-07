using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp.Views.Services
{
    class NavigationService : ViewModels.Services.INavigationService
    {
        public async Task NavigateToLogin()
        {
            await MvvmApp.App.Current.MainPage.Navigation.PushAsync(new Views.LoginView());
        }

        public async Task NavigateToMain()
        {
            await MvvmApp.App.Current.MainPage.Navigation.PushAsync(new Views.MainView());
        }

        public async Task NavigateToRegister()
        {
            await MvvmApp.App.Current.MainPage.Navigation.PushAsync(new Views.RegisterView());
        }
    }
}
