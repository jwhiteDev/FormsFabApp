using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsFABExample
{
    public partial class MainPage : ContentPage
    {
        private DataViewModel vm;
        public MainPage()
        {
            InitializeComponent();
            vm = new DataViewModel();
            this.BindingContext = vm;
            vm.OnButtonClick += HandleButtonClick;
        }

        async void HandleButtonClick(object sender, EventArgs e)
        {
            await DisplayAlert("Button Click!", "Button Was Clicked", "OK");
        }
    }
}
