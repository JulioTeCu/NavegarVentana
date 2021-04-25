using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavegarVentana
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
          if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
            {
                var uno = double.Parse(num1.Text);
                var dos = double.Parse(num2.Text);
                var suma = uno + dos;
                resultado.Text = suma.ToString();
            }
            else
            {
                DisplayAlert("Datos Erróneos", "Escribe todos los datos", "Ok");
            }
        }
    }
}