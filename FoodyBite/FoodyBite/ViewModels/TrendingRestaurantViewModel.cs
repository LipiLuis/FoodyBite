using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FoodyBite.ViewModels
{

    public class TrendingRestaurantViewModel : ViewModelBase
    {
        private BindingList<string> _ListRestaurant;
        public BindingList<string> ListRestaurant
        {
            get { return _ListRestaurant; }
            set { SetProperty(ref _ListRestaurant, value); }
        }

        public TrendingRestaurantViewModel(INavigationService navigationService) : base(navigationService)
        {

            ListRestaurant = new BindingList<string>
            {
                "Login_img",
                "Register_img",
                "Login_img",
                "Register_img",
                "Login_img",
                "Register_img",
                "Login_img",
                "Register_img",
                "Login_img",
                "Register_img"

            };
        }
    }
}

