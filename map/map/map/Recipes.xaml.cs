﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
// So that we can read the data from the JSON file
using Utils;

namespace map
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recipes : ContentPage
    {
        // List of type Recipe
        List<Recipe> recipeList;

        // Variables to check if favorite button 
        // or the buy ingredients button has been hit
        public static int favClicked;
        public static int spagBuy;

        public Recipes()
        {
            InitializeComponent();
            // Call defaults method on page load
            SetDefaults();
        }

        private void SetDefaults()
        {
            // If there's nothing in the recipe list Create a new one
            if (recipeList == null) recipeList = new List<Recipe>();
            // Populate the list with the data from the spaghetti bolognese JSON file
            recipeList = Utils.Utils.ReadRecipeData("map.Data.spag.txt");
            // Give the recipeList to the listview to display the data
            lvRecipe.ItemsSource = recipeList;
        }

        // Handles when buy ingredients button has been clicked
        private void BuyIngredients_Clicked(object sender, EventArgs e)
        {
            // Set buy variable to 1
            spagBuy = 1;
            // Navigate to basket
            Navigation.PushAsync(new Basket());
        }

        // Handles when save to favorites button has been clicked
        private void SaveToFav_Clicked(object sender, EventArgs e)
        {
            // Set favorite variable to 1
            favClicked = 1;
            // Display an alert that favorite has been added
            DisplayAlert("Favorite Added", "Added to Favorites!", "Okay", "Cancel");
        }

        // Gives the stacklayouts a binding context to the data
        private void LvRecipe_ItemLoad(object sender, SelectedItemChangedEventArgs e)
        {
            RecipeStack.BindingContext = (Recipe)e.SelectedItem;
            YoutubeStack.BindingContext = (Recipe)e.SelectedItem;
        }

        // Handles when the favorite button at the top of the page is clicked
        private void Favorites_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Favorites());
        }
    }
}