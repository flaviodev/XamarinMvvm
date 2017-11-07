using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp.ViewModels.Services
{
    interface IMessageService
    {
        Task ShowAsync(string message);
    }
}
