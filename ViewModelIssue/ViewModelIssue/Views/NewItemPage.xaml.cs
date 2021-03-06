using System;
using System.Collections.Generic;
using System.ComponentModel;
using ViewModelIssue.Models;
using ViewModelIssue.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewModelIssue.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}