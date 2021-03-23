using System.Collections.ObjectModel;
using System.Windows.Input;
using ViewModelIssue.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewModelIssue.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomView1 : ContentView
    {
        public static readonly BindableProperty IsRefreshingProperty = BindableProperty.Create(
            nameof(IsRefreshing), typeof(bool), typeof(CustomView1),
            false, BindingMode.TwoWay,
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (bindableObject is CustomView1 view)
                {
                    view.IsRefreshing = (bool)newValue;
                }
            });

        public bool IsRefreshing
        {
            get => (bool)GetValue(IsRefreshingProperty);
            set => SetValue(IsRefreshingProperty, value);
        }

        public static readonly BindableProperty DataProperty = BindableProperty.Create(
            nameof(Data), typeof(ItemData), typeof(CustomView1),
            new ItemData(), BindingMode.TwoWay,
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (bindableObject is CustomView1 view)
                {
                    view.Data = (ItemData)newValue;
                }
            });

        public ItemData Data
        {
            get => (ItemData)GetValue(DataProperty);
            set
            {
                SetValue(DataProperty, value);
                PrepareData();
            }
        }

        public static readonly BindableProperty RefreshCommandProperty = BindableProperty.Create(
            nameof(RefreshCommand), typeof(Command), typeof(CustomView1),
            null, BindingMode.TwoWay,
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (bindableObject is CustomView1 view)
                {
                    view.RefreshCommand = (ICommand)newValue;
                }
            });

        public ICommand RefreshCommand
        {
            get => (ICommand)GetValue(RefreshCommandProperty);
            set => SetValue(RefreshCommandProperty, value);
        }

        public ObservableCollection<Item> Items { get; set; } =
            new ObservableCollection<Item>();

        public CustomView1()
        {
            InitializeComponent();
        }

        private void PrepareData()
        {
            //Items.Clear();
            foreach (var item in Data.Items)
            {
                Items.Add(new Item {Text = $"{item.Id} - {item.Text}"});
            }
        }
    }
}