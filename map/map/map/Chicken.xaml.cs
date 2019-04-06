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
	public partial class Chicken : ContentPage
	{
        List<Recipe> recipeList;

        public Chicken()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {
            if (recipeList == null) recipeList = new List<Recipe>();
            recipeList = Utils.Utils.ReadRecipeData("map.Data.chicken.txt");
            ClickOnCanvas();
            lvRecipe.ItemsSource = recipeList;
        }

        private void ClickOnCanvas()
        {

        }

        private void BuyIngredients_Clicked(object sender, EventArgs e)
        {

        }

        private void SaveToFav_Clicked(object sender, EventArgs e)
        {

        }

        private void LvRecipe_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            RecipeStack.BindingContext = (Recipe)e.SelectedItem;
            YoutubeStack.BindingContext = (Recipe)e.SelectedItem;
        }
    }
}