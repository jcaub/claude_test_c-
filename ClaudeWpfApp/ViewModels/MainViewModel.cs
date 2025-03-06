using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ClaudeWpfApp.Models;

namespace ClaudeWpfApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _currentViewModel;
        private HomeViewModel _homeViewModel;
        private DossierDetailViewModel _dossierDetailViewModel;
        private AdminViewModel _adminViewModel;

        public BaseViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateDossierDetailCommand { get; }
        public ICommand NavigateAdminCommand { get; }
        public ICommand ExitCommand { get; }

        public MainViewModel()
        {
            // Initialize ViewModels
            _homeViewModel = new HomeViewModel();
            _homeViewModel.DossierSelected += OnDossierSelected;
            _dossierDetailViewModel = new DossierDetailViewModel();
            _adminViewModel = new AdminViewModel();

            // Set initial view
            CurrentViewModel = _homeViewModel;

            // Initialize commands
            NavigateHomeCommand = new RelayCommand(_ => NavigateToHome());
            NavigateDossierDetailCommand = new RelayCommand(_ => NavigateToDossierDetail());
            NavigateAdminCommand = new RelayCommand(_ => NavigateToAdmin());
            ExitCommand = new RelayCommand(_ => Exit());
        }

        private void NavigateToHome()
        {
            CurrentViewModel = _homeViewModel;
        }

        private void NavigateToDossierDetail()
        {
            CurrentViewModel = _dossierDetailViewModel;
        }

        private void NavigateToAdmin()
        {
            CurrentViewModel = _adminViewModel;
        }

        private void Exit()
        {
            Environment.Exit(0);
        }

        private void OnDossierSelected(Dossier dossier)
        {
            _dossierDetailViewModel.CurrentDossier = dossier;
            NavigateToDossierDetail();
        }
    }
}