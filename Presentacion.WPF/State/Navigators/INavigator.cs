﻿using Presentacion.WPF.ViewModels;
using System;

namespace Presentacion.WPF.State.Navigators
{
    public enum ViewType
    {
        Login,
        Home,
        ModifyPrices,
        RegisterEntry
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        event Action StateChanged;
    }
}
