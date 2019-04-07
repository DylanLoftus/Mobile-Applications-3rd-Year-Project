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
	public partial class Basket : ContentPage
	{
        private double grandTotals;

		public Basket ()
		{
			InitializeComponent ();
            SetDefaults();
		}

        private void SetDefaults()
        {
            if (Bread.breadBuy == 0)
            {
                breadbasket.IsVisible = false;
            }
            else
            {
                double total = 11.0;
                grandTotals += total;
                breadbasket.IsVisible = true;
            }

            if (Chicken.chickenBuy == 0)
            {
                chickenbasket.IsVisible = false;
            }
            else
            {
                double total = 31.85;
                grandTotals += total;
                chickenbasket.IsVisible = true;
            }

            if (Chilli.chilliBuy == 0)
            {
                chillibasket.IsVisible = false;
            }
            else
            {
                double total = 23.70;
                grandTotals += total;
                chillibasket.IsVisible = true;
            }

            if (Eggs.eggsBuy == 0)
            {
                eggsbasket.IsVisible = false;
            }
            else
            {
                double total = 13.83;
                grandTotals += total;
                eggsbasket.IsVisible = true;
            }

            if (Fruit.fruitBuy == 0)
            {
                fruitbasket.IsVisible = false;
            }
            else
            {
                double total = 11.54;
                grandTotals += total;
                fruitbasket.IsVisible = true;
            }

            if (Spag.spagBuy == 0)
            {
                spagbasket.IsVisible = false;
            }
            else
            {
                double total = 28.66;
                grandTotals += total;
                spagbasket.IsVisible = true;
            }
            grandTotal.Text = grandTotals.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Purchase!", "Item(s) purchased", "Okay", "Cancel");
            Navigation.PushAsync(new Food());
        }
    }
}