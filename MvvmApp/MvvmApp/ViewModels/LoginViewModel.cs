using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmApp.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        string email;
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
                this.Notify("Email");
            }
        }

        string password;
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
                this.Notify("Password");
            }
        }

        public ICommand LoginCommand
        {
            get;
            set;
        }

        public ICommand RegisterCommand
        {
            get;
            set;
        }

        private readonly Services.IMessageService _messageService;
        private readonly Services.INavigationService _navigationService;

        public LoginViewModel()
        {
            this.LoginCommand = new Command(this.Login);
            this.RegisterCommand = new Command(this.Register);
            this._messageService = DependencyService.Get<Services.IMessageService>();
            this._navigationService = DependencyService.Get<Services.INavigationService>();
        }

        private async void Login()
        {
            if(this.Email == "admin" && this.Password == "123")
            {
                await this._navigationService.NavigateToMain();
            } else
            {
                await this._messageService.ShowAsync("Email e/ou senha inválidos...");
            }
        }

        private async void Register()
        {
            await this._navigationService.NavigateToRegister();
        }

    }
}
