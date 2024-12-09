// StringBuilder
using System.Text;
//string word = "Salam";

//for (int i = 0; i < 100; i++)
//{
//    word += 'a';
//}
//Console.WriteLine(word);

StringBuilder sb = new StringBuilder("Salam");
for (int i = 0; i < 100; i++)
{
    sb.Append("a");
    //Console.WriteLine(sb.Capacity);
}
var str = sb.ToString();
Console.WriteLine(sb);