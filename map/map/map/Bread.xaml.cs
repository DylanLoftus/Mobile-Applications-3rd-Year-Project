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
	public partial class Bread : ContentPage
	{
        List<Recipe> recipeList;

		public Bread ()
		{
			InitializeComponent ();
            SetDefaults();
		}

        private void SetDefaults()
        {
            if (recipeList == null) recipeList = new List<Recipe>();
            recipeList = Utils.Utils.ReadRecipeData("map.Data.bread.txt");
        }

        private void BuyIngredients_Clicked(object sender, EventArgs e)
        {

        }

        private void SaveToFav_Clicked(object sender, EventArgs e)
        {

        }
    }
}