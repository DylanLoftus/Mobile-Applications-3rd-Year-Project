using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace map
{
    // Recipe object class
	public class Recipe : ContentPage
	{
        public string url { get; set; }
        public string ingredients { get; set; }
        public string instructions { get; set; }
       
        // Blank constructor
		public Recipe ()
		{
			
		}

        // Constructor with 3 inputs
        public Recipe(string u, string i, string ins)
        {
            url = u;
            ingredients = i;
            instructions = ins;
        }


    }
}