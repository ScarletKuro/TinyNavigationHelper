﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TinyNavigationHelper
{
    public interface INavigationHelper
    {
        void SetRootView(string key, bool withNavigation = true);
        void SetRootView(string key, object parameter, bool withNavigation = true);
        Task NavigateToAsync(string key);
        Task NavigateToAsync(string key, object parameter);
        Task OpenModalAsync(string key, bool withNavigation = false);
        Task OpenModalAsync(string key, object parameter, bool withNavigation = false);
        Task CloseModalAsync();
        Task BackAsync();
    }
}
