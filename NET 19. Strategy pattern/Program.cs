// Strategy pattern

// Dependency Inversion Principle

#region Serializable example
//WorkToFile workToFile = new(new XMLSerialization());
//workToFile.Serialize();
//workToFile.Deserialize();
//workToFile.SetSerialization(new NadirZamanovSerialization());
//workToFile.Serialize();
//workToFile.Deserialize();

//interface ISerialize
//{
//    void Serialize();
//    void Deserialize();
//}

//class XMLSerialization: ISerialize
//{
//    public void Serialize()
//    {
//        Console.WriteLine("XML Serialize");
//    }
//    public void Deserialize()
//    {
//        Console.WriteLine("XML Deserialize");
//    }
//}

//class JSONSerialization : ISerialize
//{
//    public void Serialize()
//    {
//        Console.WriteLine("JSON Serialize");
//    }
//    public void Deserialize()
//    {
//        Console.WriteLine("JSON Deserialize");
//    }
//}

//class NadirZamanovSerialization : ISerialize
//{
//    public void Serialize()
//    {
//        Console.WriteLine("NadirZamanov SUPPER Serialize");
//    }
//    public void Deserialize()
//    {
//        Console.WriteLine("NadirZamanov SUPPER Deserialize");
//    }
//}

//class WorkToFile // Strategy
//{
//    private  ISerialize _serialization { get; set; }

//    public WorkToFile(ISerialize serialization)
//    {
//        _serialization = serialization;
//    }

//    public void SetSerialization(ISerialize serialization)
//    {
//        _serialization = serialization;
//    }

//    public void Serialize()
//    {
//        _serialization.Serialize();
//    }
//    public void Deserialize()
//    {
//        _serialization.Deserialize();
//    }
//}

#endregion

#region SortingExample
List<int> ints = [54, 7, -1, 35, 111, -23, 67, 10, 33];
//ints.Sort();
ints.ForEach(i => Console.Write($"{i} "));
Console.WriteLine();
Sorting<int> sorting = new(new SelectionSorting());
var lst = sorting.Sort(ints);
lst.ForEach(i => Console.Write($"{i} "));


interface ISorting<T>
{
    List<T> Sort(List<T> collection);
}

class BubbleSort : ISorting<int>
{
    public List<int> Sort(List<int> collection)
    {
        for (int i = 0; i < collection.Count - 1; i++) {
            for (int j = 0; j < collection.Count - i - 1; j++)
            {
                if (collection[j] > collection[j + 1])
                {
                    var tmp = collection[j];
                    collection[j] = collection[j + 1];
                    collection[j + 1] = tmp;
                }
            }
        }
        return collection;
    }
}


class SelectionSorting : ISorting<int>
{
    public List<int> Sort(List<int> collection)
    {
        for (int i = 0; i < collection.Count; i++)
        {
            var minValIndex = i;
            for (int j = i+1; j < collection.Count; j++)
            {
                if (collection[j] < collection[minValIndex])
                {
                    minValIndex = j;
                }
            }
            var tmp = collection[minValIndex];
            collection[minValIndex] = collection[i];
            collection[i] = tmp;
        }
        return collection;
    }
}

class Sorting<T>
{
    private ISorting<T> _sorting;

    public Sorting(ISorting<T> sorting)
    {
        _sorting = sorting;
    }

    public List<T> Sort(List<T> col) => _sorting.Sort(col);
}

#endregion