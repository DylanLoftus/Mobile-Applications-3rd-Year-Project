using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;
using map;

namespace Utils
{
	public class Utils
	{
        public const string JSON_RECIPE_FILE = "bread.txt";

        public static List<Recipe> ReadRecipeData(string datatext)
        {
            List<Recipe> myList = new List<Recipe>();
            string jsonText;

            try  // reading the localApplicationFolder first
            {
                string path = Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData);
                string filename = Path.Combine(path, JSON_RECIPE_FILE);
                using (var reader = new StreamReader(filename))
                {
                    jsonText = reader.ReadToEnd();
                    // need json library
                }
            }
            catch // fallback is to read the default file
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(
                                                typeof(MainPage)).Assembly;
                //Assembly.GetExecutingAssembly().GetManifestResourceNames();
                // create the stream
                Stream stream = assembly.GetManifestResourceStream(datatext);
                using (var reader = new StreamReader(stream))
                {
                    jsonText = reader.ReadToEnd();
                    // include JSON library now
                }
            }
            myList = JsonConvert.DeserializeObject<List<Recipe>>(jsonText);

            return myList;
        }
    }
}