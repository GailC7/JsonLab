using JsonLab.Models;
using Newtonsoft.Json;
using System.Data;
using System.Text.Json;



var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
var data = root + Path.DirectorySeparatorChar + "data";
var file = data + Path.DirectorySeparatorChar + "Hellsing.json";

var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true};

//Deserializing JSON data

    foreach (string fileName in Directory.GetFiles(data))
    {
        // set JSON string to empty and set up streamreader based on data file's path
        string jsonString = string.Empty;
        using (StreamReader sr = new StreamReader(fileName))
        {
            jsonString = sr.ReadToEnd();
        }

        // deserialize (read) JSON and create object(s) based on its information
        //var book = JsonSerializer.Deserialize<Book>(jsonString, options);
        //Console.WriteLine(book);


        Book deserializedProduct = JsonConvert.DeserializeObject<Book>(jsonString);
        Console.WriteLine(deserializedProduct);
}



//Serialize a new book 
VolumeInfo v = new VolumeInfo("Tip Tappin", "Tippy Tappy", new string[] {"Tim Tam"});
Items i = new Items("isORjdp", "https://www.googleapis.com/books/v1/volumes/M4YnteeYLO0C", v);
Book newBook = new Book(new Items[] { i });
//string newBookjson = JsonSerializer.Serialize<Book>(newBook);
//Console.WriteLine(newBookjson);

string output = JsonConvert.SerializeObject(newBook);


