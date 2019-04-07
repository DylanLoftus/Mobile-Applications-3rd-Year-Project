using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;
// So the rest of the project can see Utils
using map;

namespace Utils
{
	public class Utils
	{
        public const string JSON_RECIPE_FILE = "bread.txt";

        // Method to Read Data from either the Local Application Folder or the Data folder.
        public static List<Recipe> ReadRecipeData(string datatext)
        {
            // Creating a list of type recipe
            List<Recipe> myList = new List<Recipe>();
            // Creating a string to put the JSON data into
            string jsonText;

            try  // reading the localApplicationFolder first
            {
                string path = Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData);
                string filename = Path.Combine(path, JSON_RECIPE_FILE);
                using (var reader = new StreamReader(filename))
                {
                    jsonText = reader.ReadToEnd();
                    // Read through the jsonText varibale
                }
            }
            catch // fallback is to read the default file
            {
                // Creating the assembly
                var assembly = IntrospectionExtensions.GetTypeInfo(
                                                typeof(MainPage)).Assembly;
                // Creating the stream
                Stream stream = assembly.GetManifestResourceStream(datatext);
                using (var reader = new StreamReader(stream))
                {
                    jsonText = reader.ReadToEnd();
                    // Read through the jsonText varibale
                }
            }

            // Deserilize the jsonText into a list of type Recipe
            myList = JsonConvert.DeserializeObject<List<Recipe>>(jsonText);

            // Return the recipe list
            return myList;
        }
    }
}