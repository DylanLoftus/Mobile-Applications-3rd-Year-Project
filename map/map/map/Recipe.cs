using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace map
{
	public class Recipe : ContentPage
	{
        public string url { get; set; }
        public string ingredients { get; set; }
        public string instructions { get; set; }
       

		public Recipe ()
		{
			
		}

        public Recipe(string u, string i, string ins)
        {
            url = u;
            ingredients = i;
            instructions = ins;
        }


    }
}