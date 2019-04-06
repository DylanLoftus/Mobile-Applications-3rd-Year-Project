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
		public Food ()
		{
			InitializeComponent ();
        }

        private void Bread_Clicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new Bread());
        }
        
        private void Eggs_Clicked(object sender, EventArgs e)
        {
           
        }

        private void Chilli_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chilli());
        }

        private void Spag_Clicked(object sender, EventArgs e)
        {
             
        }

        private void Cordon_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chicken());
        }

        private void Fruit_Clicked(object sender, EventArgs e)
        {
             
        }
        
    }
}