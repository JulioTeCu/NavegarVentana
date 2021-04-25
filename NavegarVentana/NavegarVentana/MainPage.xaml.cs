using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavegarVentana
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Page1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void Page2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void Page3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}
