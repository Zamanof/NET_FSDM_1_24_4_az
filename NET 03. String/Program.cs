// String
//string str = "Hello";
//string str2 = new string("Hello");
//Console.WriteLine(str == str2);
//Console.WriteLine(str.Equals(str2));
//Console.WriteLine(str.CompareTo(str2));


//char[] chars = new char[] { 'S', 'a', 'l', 'a', 'm' };
//string str3 = new string(chars);
//Console.WriteLine(str3);
//string str4 = new string('-', 25);
//string str5 = new('-', 25);
//Console.WriteLine(str4);

// intern pool
//string name = "Nadir";
//string name2 = "Nadir";
//string myName = name;
//string name3 = new string("Nadir");
//string na = "Na";
//string dir = "dir";
//string name4 = na + dir; 
//Console.WriteLine(object.ReferenceEquals(name, name2));
//Console.WriteLine(object.ReferenceEquals(name, name3));
//Console.WriteLine(object.ReferenceEquals(name, name4));
//Console.WriteLine(object.ReferenceEquals(name, myName));

// string ranges, indices
//string word = "lorem ipsum dolor sir amet";
//Console.WriteLine(word[0]);
//Console.WriteLine(word[0..6]);
//Console.WriteLine(word[^1]);
//Console.WriteLine(word[0].ToString().ToUpper() + word[1..]);

//var myWord = "Lorem,    ipsum! dolor,,,,  sit,     amets";
//Console.WriteLine(myWord.ToLower());
//Console.WriteLine(myWord.ToUpper());
//var strings = myWord.Split(',', StringSplitOptions.TrimEntries) ;
//var otherStrings = myWord.Split(',', StringSplitOptions.RemoveEmptyEntries);
//foreach (var s in strings)
//{
//    Console.Write($"{s}\t");
//}
//Console.WriteLine();
//foreach (var s in otherStrings)
//{
//    Console.WriteLine(s);
//}

//Console.WriteLine(myWord.IndexOf('a'));

//string myWord2 = """
//    foreach (var s in strings)
//    {
//        Console.Write($"{s}\t");
//    }
//    Console.WriteLine();
//    foreach (var s in otherStrings)
//    {
//        Console.WriteLine(s);
//    } 
//    """;

//Console.WriteLine(myWord2);

