using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp.Views.Services
{
    class MessageService : ViewModels.Services.IMessageService
    {
        public async Task ShowAsync(string message)
        {
            await MvvmApp.App.Current.MainPage.DisplayAlert("Mvvm", message, "ok");
        }
    }
}
