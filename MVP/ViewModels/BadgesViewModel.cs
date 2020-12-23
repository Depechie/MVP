﻿using MVP.Services.Interfaces;
using TinyMvvm;

namespace MVP.ViewModels
{
    public class BadgesViewModel : BaseViewModel
    {
        public BadgesViewModel(IAnalyticsService analyticsService, INavigationHelper navigationHelper)
            : base(analyticsService, navigationHelper)
        {
        }
    }
}
