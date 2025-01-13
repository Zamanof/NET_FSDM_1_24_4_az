// yield return, yield break

var hellos = GetResults();
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext(); 
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);
//hellos.MoveNext();
//Console.WriteLine(hellos.Current);

//while (hellos.MoveNext())
//{
//    Console.WriteLine(hellos.Current);
//}


//var results = GetValues();
//foreach (var item in results)
//{
//    Console.WriteLine(item);
//}

string text = "Lorem Ipsum dolor sit amet";
foreach (var i in MyRange(3, text.Length, 2))
{
    Console.Write($"{text[i]} ");
    //Console.Write($"{i} ");
}

IEnumerator<string> GetResults()
{
    yield return "Salam";
    yield return "Aleykum salam";
    yield return "Hi";
    yield return "Hola";
    yield return "Aloha";
}

IEnumerable<string> GetValues()
{
    var strings = new List<string>()
    {
        "Saqol", "Goodbye", "Elvida", "Poka", "Dosvidaniye", "Aloha"
    };
    for (int i = 0; i < strings.Count; i++)
    {
        yield return strings[i].ToUpper();
    }
}

IEnumerable<int> MyRange(int start, int? end = null, int steps = 1)
{
    if (start > end && steps > 0) yield break;
    if (end is null)
    {
        end = start;
        start = 0;
    }
    for (int i = start; i < end; i += steps)
    {
        yield return i;
    }
}