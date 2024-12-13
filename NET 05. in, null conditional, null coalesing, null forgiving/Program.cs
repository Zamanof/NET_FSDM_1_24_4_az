// in reference - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters#in-parameter-modifier
// ?. - null conditional https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-
// ?? - null coalesing https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
// ! - null forgiving https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving

#region in reference

//MyStruct myStruct = new MyStruct() {
//    value1 = 25,
//    value2 = 50,
//    value3 = 30
//};

//Foo(in myStruct);

//void Foo(in MyStruct myStruct)
//{
//    Console.WriteLine(myStruct.value1);
//    Console.WriteLine(myStruct.value2);
//    Console.WriteLine(myStruct.value3);
//}
#endregion

#region .? null conditional

//string name = null;

//if (name != null)
//{
//    name = name.ToLower();
//    Console.WriteLine(name);
//}

//if (name is not null)
//{
//    name = name.ToLower();
//    Console.WriteLine(name);
//}
//name = name?.ToLower();
//Console.WriteLine(name);


#endregion

#region ?? null coalesing
//string str = null;
//if (str is null)
//{
//    str = "Empty";
//}
//Console.WriteLine(str);

//string str1 = str is null?"Empty":str;
//Console.WriteLine(str1);

//string str2 = str ?? "Empty";
//Console.WriteLine(str2);

#endregion

#region Nullable type
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types
//Nullable<int> code = null;
//int? databaseValue = 78;
//int? index = databaseValue;
//Console.WriteLine(index + 26);
#endregion

#region ! - null forgiving

string name = null!;
Console.WriteLine(name);
#endregion
struct MyStruct
{
    public int value1;
    public int value2;
    public int value3;
}