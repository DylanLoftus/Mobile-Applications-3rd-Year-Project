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
	public partial class Eggs : ContentPage
	{
        List<Recipe> recipeList;
        public static int favClicked;
        public static int eggsBuy;

        public Eggs()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {
            if (recipeList == null) recipeList = new List<Recipe>();
            recipeList = Utils.Utils.ReadRecipeData("map.Data.eggs.txt");
            lvRecipe.ItemsSource = recipeList;
        }

        private void BuyIngredients_Clicked(object sender, EventArgs e)
        {
            eggsBuy = 1;
            Navigation.PushAsync(new Basket());
        }

        private void SaveToFav_Clicked(object sender, EventArgs e)
        {
            favClicked = 1;
            DisplayAlert("Favorite Added", "Added to Favorites!", "Okay", "Cancel");
        }

        private void LvRecipe_ItemLoad(object sender, SelectedItemChangedEventArgs e)
        {
            RecipeStack.BindingContext = (Recipe)e.SelectedItem;
            YoutubeStack.BindingContext = (Recipe)e.SelectedItem;
        }

        private void Favorites_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Favorites());
        }
    }
}