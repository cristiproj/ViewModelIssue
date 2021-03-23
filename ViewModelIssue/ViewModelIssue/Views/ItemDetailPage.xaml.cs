using System.ComponentModel;
using ViewModelIssue.ViewModels;
using Xamarin.Forms;

namespace ViewModelIssue.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}