using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace map
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Food : ContentPage
	{
        public static int favClicked;
        public static int tap2hit = 0;

        public Food ()
		{
			InitializeComponent ();
        }

        // Navigate to Garlic bread page
        private void Bread_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bread());
        }
       
        // Navigate to Scrambled Eggs page
        private void Eggs_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Eggs());
        }

        // Navigate to Chilli Con Carne page
        private void Chilli_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chilli());
        }

        // Navigate to Spaghetti Bolognese page
        private void Spag_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Spag());
        }

        // Navigate to Chicken Cordon Bleu page
        private void Cordon_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chicken());
        }

        // Navigate to Fruit Salad page
        private void Fruit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fruit());
        }

        // Navigate to Favorites page
        private void Favorites_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Favorites());
        }

    }
}