using CSCI2910_Lab6_Newtonsoft.Models;
using Newtonsoft.Json;

namespace CSCI2910_Lab6_Newtonsoft
{
    public class Program
    {
        static void Main(string[] args)
        {
            // path to the JSON files
            var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            var filePath = root + $"{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}oathbringer.json";
            var dataPath = root + $"{Path.DirectorySeparatorChar}Data";
            var outputPath = root + $"{Path.DirectorySeparatorChar}Output";

            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.Formatting = Formatting.Indented;

            var bookList = new List<Book>();
            foreach (string fileName in Directory.GetFiles(dataPath))
            {
                // set JSON string to empty and set up streamreader based on data file's path
                string jsonReadString = string.Empty;
                using (StreamReader sr = new StreamReader(fileName))
                {
                    jsonReadString = sr.ReadToEnd();
                }

                // deserialize JSON and create objects

                Book deserializedBook = JsonConvert.DeserializeObject<Book>(jsonReadString);
                
                bookList.Add(deserializedBook);
            }

            //foreach (Book book in bookList)
            //{
                //Console.WriteLine(book);
            //}

            // serialize JSON from object
            using ( StreamWriter sw = new StreamWriter(outputPath + $"{Path.DirectorySeparatorChar}book.JSON", false))
            {
                try
                {
                    string output = JsonConvert.SerializeObject(bookList, Formatting.Indented);
                    sw.WriteLine(output);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }


        }
    }
}