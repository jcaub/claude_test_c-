using ClaudeWpfApp.Models;

namespace ClaudeWpfApp.ViewModels
{
    public class DossierDetailViewModel : BaseViewModel
    {
        private Dossier _currentDossier;

        public Dossier CurrentDossier
        {
            get => _currentDossier;
            set => SetProperty(ref _currentDossier, value);
        }

        public DossierDetailViewModel()
        {
            // Initialize with empty dossier
            CurrentDossier = new Dossier();
        }
    }
}