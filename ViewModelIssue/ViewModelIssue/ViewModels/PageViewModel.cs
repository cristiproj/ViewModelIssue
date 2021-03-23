using System.Windows.Input;
using Xamarin.Forms;


namespace ViewModelIssue.ViewModels
{
    public abstract class PageViewModel: BaseViewModel
    {
        private bool isRefreshing;
        protected abstract void PrepareData();
        
        public ICommand RefreshCommand { get; }

        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public PageViewModel()
        {
            RefreshCommand = new Command(() =>
            {
                PrepareData();
                IsRefreshing = false;
            });
        }

        
    }
}
