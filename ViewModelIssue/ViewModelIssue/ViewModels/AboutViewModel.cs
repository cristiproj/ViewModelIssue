using System;
using System.Windows.Input;
using ViewModelIssue.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ViewModelIssue.ViewModels
{
    public class AboutViewModel : PageViewModel
    {
        private ItemData data;

        public ICommand OpenWebCommand { get; }

        public ItemData Data
        {
            get => data;
            set => SetProperty(ref data, value);
        }

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public void Initialize()
        {
            Data = new ItemData();
            PrepareData();
        }

        protected override void PrepareData()
        {
            Data.Items.Clear();
            Data.Items.Add(new Item { Id = "1", Text = $"Circle {DateTime.Now.Minute}" });
            Data.Items.Add(new Item { Id = "2", Text = $"Square {DateTime.Now.Second}" });
            Data.Items.Add(new Item { Id = "3", Text = $"Rectangle {DateTime.Now.Millisecond}" });
        }
    }
}
