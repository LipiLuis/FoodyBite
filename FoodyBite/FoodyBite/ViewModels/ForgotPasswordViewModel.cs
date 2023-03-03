using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodyBite.ViewModels
{
    public class ForgotPasswordViewModel : ViewModelBase
    {
        public DelegateCommand BackCommand { get; set; }
        public ForgotPasswordViewModel(INavigationService navigationService) : base(navigationService)
        {
            BackCommand = new DelegateCommand(async () => await navigationService.GoBackAsync());
        }
    }
}
