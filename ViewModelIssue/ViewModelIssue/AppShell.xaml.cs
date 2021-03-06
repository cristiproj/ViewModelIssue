using System;
using System.Collections.Generic;
using ViewModelIssue.ViewModels;
using ViewModelIssue.Views;
using Xamarin.Forms;

namespace ViewModelIssue
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
