using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Utils;

namespace map
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Favorites : ContentPage
	{
        public Favorites()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {
            if (Bread.favClicked == 0)
            {
                bread.IsVisible = false;
            }
            else
            {
                bread.IsVisible = true;
            }

            if(Chicken.favClicked == 0)
            {
                cordon.IsVisible = false;
            }
            else
            {
                cordon.IsVisible = true;
            }

            if(Chilli.favClicked == 0)
            {
                chilli.IsVisible = false;
            }
            else
            {
                chilli.IsVisible = true;
            }

            if(Eggs.favClicked == 0)
            {
                eggs.IsVisible = false;
            }
            else
            {
                eggs.IsVisible = true;
            }

            if(Fruit.favClicked == 0)
            {
                fruit.IsVisible = false;
            }
            else
            {
                fruit.IsVisible = true;
            }

            if(Spag.favClicked == 0)
            {
                spag.IsVisible = false;
            }
            else
            {
                spag.IsVisible = true;
            }
            
        }

        private void Bread_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bread());
        }

        private void Eggs_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Eggs());
        }

        private void Chilli_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chilli());
        }

        private void Spag_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Spag());
        }

        private void Cordon_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chicken());
        }

        private void Fruit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fruit());
        }

        private void Favorites_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Favorites());
        }
    }
}