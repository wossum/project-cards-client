﻿using ProjectCards.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ProjectCards.Pages
{
    public partial class HomePage : ContentPage
    {
        private HomeViewModel _HomeViewModel;
        public HomeViewModel ViewModel
        {
            get
            {
                return (_HomeViewModel ?? new HomeViewModel());
            }
        }
        
        public HomePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // The navigation logic startup needs to diverge per platform in order to meet the UX design requirements
        }
    }
}

