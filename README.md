# Mobile App Project 2019 - Recipes For You (3rd Year Project)

### How to use the app

* Launch the app.
* Hit the Enter Button.
* Click/Tap on a Recipe to view the recipe.
* Hit "Buy Ingredients Here" to add ingredients to basket.
* Hit the "Save to Favorites" button to add the recipe to the favorites page.

### Written In

* [Xamarin](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/)
* Language : C#/Xaml
* [Visual Studio 2017 Version 15.9.8](https://visualstudio.microsoft.com/downloads/)

### Research

* Data binding used with List Views.
* Using ImageButtons to Navigate throughtout the app.
* Embedding Youtube videos can be done through a WebView.

### How the app works.

* To get the Data for each recipe on each recipe page. The Data is read through a JSON file and deserialized into a list of type "Recipe".
* It is then Data bound to a ListView on each page.
* The ListView got in the way of the app. So to go around that I put the ListView to the top of the page and set the "IsVisible" attribute to false.
* To then load the data automatically onto the page I used the "IsAppearing" attribute instead of the "ItemSelected" attribute.
* The Favorites page is copy of the Food Page but all the elements are invisible unless the "Save to Favorites" button has been hit on a Recipe page.
* The basket page is a page with pictures of baskets with the ingredients to each recipe. They are all invisible unless the "Buy Ingredients Here!" button is hit on a Recipe Page.



