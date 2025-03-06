using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ClaudeWpfApp.Models;

namespace ClaudeWpfApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private ObservableCollection<Dossier> _dossiers;
        private Dossier _selectedDossier;

        public event Action<Dossier> DossierSelected;

        public ObservableCollection<Dossier> Dossiers
        {
            get => _dossiers;
            set => SetProperty(ref _dossiers, value);
        }

        public Dossier SelectedDossier
        {
            get => _selectedDossier;
            set
            {
                if (SetProperty(ref _selectedDossier, value) && _selectedDossier != null)
                {
                    DossierSelected?.Invoke(_selectedDossier);
                }
            }
        }

        public HomeViewModel()
        {
            // Initialize with sample data
            Dossiers = new ObservableCollection<Dossier>
            {
                new Dossier { Id = 1, Nom = "Dossier 1", Description = "Description du dossier 1" },
                new Dossier { Id = 2, Nom = "Dossier 2", Description = "Description du dossier 2" },
                new Dossier { Id = 3, Nom = "Dossier 3", Description = "Description du dossier 3" },
            };
        }
    }
}