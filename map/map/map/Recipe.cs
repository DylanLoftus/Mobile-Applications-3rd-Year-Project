using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace map
{
	public class Recipe : ContentPage
	{
        public string Url { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }

        public Recipe()
        {

        }

        public Recipe(string u, string i, string ins)
        {
            Url = u;
            Ingredients = i;
            Instructions = ins;
        }
    }
}