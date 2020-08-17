﻿using Presentacion.WPF.State.Navigators;
using System;

namespace Presentacion.WPF.ViewModels.Factories
{
    public class ViewModelFactory : IViewModelFactory
    {
        #region Constructor
        public ViewModelFactory(CreateViewModel<HomeViewModel> createHomeViewModel,
                                CreateViewModel<LoginViewModel> createLoginViewModel,
                                CreateViewModel<ModifyPricesViewModel> createModifyPricesViewModel,
                                CreateViewModel<RegisterEntryViewModel> createRegisterEntryViewModel,
                                CreateViewModel<RegisterDepartureViewModel> createRegisterDepartureViewModel,
                                CreateViewModel<SearchTicketsViewModel> createSearchTicketsViewModel, 
                                CreateViewModel<SearchBillsViewModel> createSearchBillsViewModel)
        {
            _createHomeViewModel = createHomeViewModel;
            _createLoginViewModel = createLoginViewModel;
            _createModifyPricesViewModel = createModifyPricesViewModel;
            _createRegisterEntryViewModel = createRegisterEntryViewModel;
            _createRegisterDepartureViewModel = createRegisterDepartureViewModel;
            _createSearchTicketsViewModel = createSearchTicketsViewModel;
            _createSearchBillsViewModel = createSearchBillsViewModel;
        }

        #endregion

        #region Variables
        private readonly CreateViewModel<LoginViewModel> _createLoginViewModel;
        private readonly CreateViewModel<HomeViewModel> _createHomeViewModel;
        private readonly CreateViewModel<ModifyPricesViewModel> _createModifyPricesViewModel;
        private readonly CreateViewModel<RegisterEntryViewModel> _createRegisterEntryViewModel;
        private readonly CreateViewModel<RegisterDepartureViewModel> _createRegisterDepartureViewModel;
        private readonly CreateViewModel<SearchTicketsViewModel> _createSearchTicketsViewModel;
        private readonly CreateViewModel<SearchBillsViewModel> _createSearchBillsViewModel;

        #endregion

        #region Methods
        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Login:
                    return _createLoginViewModel();
                case ViewType.Home:
                    return _createHomeViewModel();
                case ViewType.ModifyPrices:
                    return _createModifyPricesViewModel();
                case ViewType.RegisterEntry:
                    return _createRegisterEntryViewModel();
                case ViewType.RegisterDeparture:
                    return _createRegisterDepartureViewModel();
                case ViewType.SearchTickets:
                    return _createSearchTicketsViewModel();
                case ViewType.SearchBills:
                    return _createSearchBillsViewModel();
                default:
                    throw new ArgumentException("The ViewType does not have a ViewModel.", "viewType");
            }
        }

        #endregion

    }
}
