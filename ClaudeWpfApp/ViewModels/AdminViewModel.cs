namespace ClaudeWpfApp.ViewModels
{
    public class AdminViewModel : BaseViewModel
    {
        private string _message;

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public AdminViewModel()
        {
            Message = "Page d'administration - Fonctionnalités à venir";
        }
    }
}