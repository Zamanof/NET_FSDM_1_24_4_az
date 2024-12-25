/*
    non-generic             generic                          c++

    ArrayList               List<T>                         vector<T>
    Stack                   Stack<T>                        stack<T>
    Queue                   Queue<T>                        queue<T>
    HashTable               Dictionary<TKey, TValue>        map<TKey, TValue>
    SortedList              SortedList<TKey, TValue>        
                            LinkedList<T>                   list<T>
 
 */

using System.Collections;

Random random = new Random();
ArrayList array = new ArrayList();
for (int i = 0; i < 25; i++)
{
    array.Add(random.Next(10, 99));
}
//Console.WriteLine(array[0] + 5);
List<int> numbers = new();
for (int i = 0; i < 25; i++)
{
    numbers.Add(random.Next(10, 99));
}
Console.WriteLine(numbers[0].GetType());
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[0] + 5);
