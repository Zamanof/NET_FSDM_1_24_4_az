// Serialization

using System.Text.Json;
using System.Xml.Serialization;

Book book = new Book()
{
    Author = new Author("Joseph", "Albahari"),
    Title = "C# 13 in a Nutshell",
    Description = "Full guide for C# Language",
    Price = 57
};
List<Book> books = new List<Book>()
{
    book,
    new Book()
{
    Author = new Author("Jeffrey", "Richter"),
    Title = "C# via CLR",
    Description = "Amaizing book",
    Price = 48.96
},
    new Book()
{
    Author = new Author("Victor", "Hugo"),
    Title = "Les Miserables",
    Description = "Dont cry",
    Price = 15.6
}
};

#region XML Serialization
// single object serialization
//XmlSerializer serializer = new XmlSerializer(typeof(Book));
//using(var file = new FileStream("book.xml", FileMode.OpenOrCreate))
//{
//    serializer.Serialize(file, book);
//}

//using (var file = new FileStream("book.xml", FileMode.Open))
//{
//    var result = (Book)serializer.Deserialize(file);
//    Console.WriteLine(result);
//}

// list of objects serialization
//XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
//using (var file = new FileStream("books.xml", FileMode.OpenOrCreate))
//{
//    serializer.Serialize(file, books);
//}

//using (var file = new FileStream("books.xml", FileMode.Open))
//{
//    var result = (List<Book>)serializer.Deserialize(file)!;
//    result.ForEach(Console.WriteLine);
//}
#endregion

#region JSON Serialization
//using (FileStream file = new("book.json", FileMode.OpenOrCreate))
//{
//    JsonSerializerOptions options = new JsonSerializerOptions();
//    options.WriteIndented = true;

//    //var json = JsonSerializer.Serialize(book, options);
//    //Console.WriteLine(json);

//    JsonSerializer.Serialize(file, book, options);
//}

//using FileStream file = new FileStream("book.json", FileMode.Open);
//var result = JsonSerializer.Deserialize<Book>(file);
//Console.WriteLine(result);


//using FileStream file = new("books.json", FileMode.OpenOrCreate);

//JsonSerializerOptions options = new JsonSerializerOptions();
//options.WriteIndented = true;

////var json = JsonSerializer.Serialize(book, options);
////Console.WriteLine(json);

//JsonSerializer.Serialize(file, books, options);


using FileStream file = new FileStream("books.json", FileMode.Open);
var result = JsonSerializer.Deserialize<List<Book>>(file);
result!.ForEach(Console.WriteLine);


#endregion