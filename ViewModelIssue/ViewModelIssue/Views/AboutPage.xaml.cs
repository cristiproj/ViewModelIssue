using System;
using System.ComponentModel;
using ViewModelIssue.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewModelIssue.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            var model = new AboutViewModel();
            model.Initialize();

            BindingContext = model;
        }
    }
}