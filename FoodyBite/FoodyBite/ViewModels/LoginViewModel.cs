using FoodyBite.Views;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodyBite.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public DelegateCommand ForgotPasswordCommand { get; set; }
        public DelegateCommand RegisterCommand { get; set; }
        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {
            ForgotPasswordCommand = new DelegateCommand(async () => await navigationService.NavigateAsync($"{nameof(ForgotPasswordPage)}", useModalNavigation: true, animated: true));
            RegisterCommand = new DelegateCommand(async () => await navigationService.NavigateAsync($"{nameof(RegisterPage)}", useModalNavigation: false, animated: false));
        }
    }
}
