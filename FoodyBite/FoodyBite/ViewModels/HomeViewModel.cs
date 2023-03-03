using FoodyBite.Views;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FoodyBite.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {

        private BindingList<string> _ListRestaurant;
        public BindingList<string> ListRestaurant
        {
            get { return _ListRestaurant; }
            set { SetProperty(ref _ListRestaurant, value); }
        }
        public DelegateCommand TrendingRestCommand { get; set; }
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {

            ListRestaurant = new BindingList<string>
            {
                "Login_img",
                "Register_img",
                "Login_img",
                "Register_img",
                "Login_img",
                "Register_img"

            };
            TrendingRestCommand = new DelegateCommand(async () => await navigationService.NavigateAsync(nameof(TrendingRestaurantPage), useModalNavigation: true, animated: true));
        }
    }
}
