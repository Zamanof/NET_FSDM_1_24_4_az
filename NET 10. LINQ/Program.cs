// LINQ - Language Integrated Query

// LINQ to Object
// LINQ to Dataset 
// LINQ to SQL 
// LINQ to Xml
// LINQ to Entities
// PLINQ - Paralell LINQ

int[] arr = [65, -652, 12, -1, 45, 13, 87, -55, 89, 653, 54, 37, -69, 18, 77, -133];
show(arr);
//IEnumerable<int> query = from i in arr
//                         select i;
//show(query);
//arr[0] = 2;
//show(query);

//// where
//query = from i in arr
//        where i < 0 && i % 2 == 0
//        select i;

//show(query);

//// orderby ascending(by default) descending
//query = from i in arr
//        where i > 0
//        orderby i descending
//        select i;
//show(query);

// group by
//var group = from i in arr
//            where i > 0
//            group i by i % 2; // 0 1

//foreach (var item in group)
//{
//    Console.WriteLine(item.Key);
//    foreach (var value in item)
//    {
//        Console.WriteLine($"    {value}");
//    }
//}


// into 
var query_into = from i in arr
                 where i > 0
                 group i by i % 2 into result
                 from j in result
                 group j by j % 10;

foreach (var item in query_into)
{
    Console.WriteLine(item.Key);
    foreach (var value in item)
    {
        Console.WriteLine($"    {value}");
    }
}

void show(IEnumerable<int> array)
{
    foreach (int i in array) Console.Write($"{i} ");
    Console.WriteLine();
}