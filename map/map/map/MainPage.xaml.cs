using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace map
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Handles when Enter button is pressed
        // Navigates to food page
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Food());
        }
    }
}

