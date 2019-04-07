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
        // To display total price of multiple recipes

		public Basket ()
		{
			InitializeComponent ();
            // Run when page is loaded
            SetDefaults();
		}

        private void SetDefaults()
        {
            // BuyIngredients_Clicked is triggered on any Recipe page
            // Make the basket picture visible 
            // Add total price of that Recipe to grand total

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
            
            // Fill grandTotal on Xaml page with the total of all Recipes
            // in string format
            grandTotal.Text = grandTotals.ToString();
        }

        // Handles when buy button is clicked
        private void Button_Clicked(object sender, EventArgs e)
        {
            // Display alert to tell the user they have bought the item(s)
            DisplayAlert("Purchase!", "Item(s) purchased", "Okay", "Cancel");
            // Navigate to food page
            Navigation.PushAsync(new Food());
        }
    }
}