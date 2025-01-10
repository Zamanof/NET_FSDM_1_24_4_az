// StreamReader, StreamWriter

using System.Text;

#region writer
//string text = "Lorem ipsum";

//FileStream file = new("file.txt", FileMode.Create);
//StreamWriter writer = new StreamWriter(file, Encoding.Unicode);
//foreach (char symbol in text)
//{
//    writer.Write($"{symbol} ");
//}
//writer.Close();
//file.Close();
#endregion

#region writer with using
//string text = "Lorem ipsum Dolor";
//using (FileStream file = new("file.txt", FileMode.Create))
//using (StreamWriter writer = new StreamWriter(file, Encoding.Unicode))
//    foreach (char symbol in text)
//    {
//        writer.Write($"{symbol} ");
//    }
#endregion



#region reader
//FileStream file = new("file.txt", FileMode.Open);

//StreamReader reader = null;
//reader = new StreamReader(file, Encoding.Unicode);
//string line = reader.ReadToEnd();
//Console.WriteLine(line);
//reader.Close();
//file.Close();
#endregion

#region reader with try finally
//FileStream file = null!;
//StreamReader reader = null!;
//try
//{
//    file = new("file.txt", FileMode.Open);

//    reader = new StreamReader(file, Encoding.Unicode);

//    string line = reader.ReadToEnd();
//    Console.WriteLine(line);
//}
//finally
//{
//    file.Close();
//    reader.Close();
//}
#endregion

#region reader with using
//using (FileStream file = new("file.txt", FileMode.Open))
//{
//    using (StreamReader reader = new StreamReader(file, Encoding.Unicode))
//    {
//        string line = reader.ReadToEnd();
//        Console.WriteLine(line);
//    }
//}
#endregion