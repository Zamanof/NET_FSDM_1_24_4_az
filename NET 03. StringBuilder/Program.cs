// StringBuilder
using System.Text;
//string word = "Salam";

//for (int i = 0; i < 100; i++)
//{
//    word += 'a';
//}
//Console.WriteLine(word);

//StringBuilder sb = new StringBuilder("Salam");
//for (int i = 0; i < 100; i++)
//{
//    sb.Append("a");
//    //Console.WriteLine(sb.Capacity);
//}
//var str = sb.ToString();
//Console.WriteLine(sb);

//var word = string.Empty;
//for (int i = 0; i < 10000; i++)
//{
//    word += $"{i}, "; 
//}
//Console.WriteLine(word);

StringBuilder sb = new StringBuilder();
int count = 0;
for (int i = 0; i < 10000; i++)
{
    if(count != sb.Capacity) Console.WriteLine(sb.Capacity);
    count = sb.Capacity;
    sb.Append($"{i}, ");

}
//Console.WriteLine(sb);
