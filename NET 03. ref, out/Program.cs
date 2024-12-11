/* 
  ref -     metodların içinə Value Type dəyişənləri reference olaraq göndərmək üçündür
            metoda göndərilməzdən əvvəl mütləq initialize(dəyər verilməlidir)
            metodun içində initialize etməyə ehtiyac yoxdur
  out -     metodların içinə Value Type dəyişənləri reference olaraq göndərmək üçündür
            metoda göndərilməzdən əvvəl initialize(dəyər verilməlidir) olunması vacib deyil
            metodun içində mütləq şəkildə initialize edilməlidir
  in  -     Gələn dərs soruşacam
*/
//int number = 56;
//int number2 = 13;
//int[] arr = [23, 65, 1, 2, 115, 45];
//Console.WriteLine("Before call method:");
//Console.WriteLine($"number = {number}, number2 = {number2}"); // 56 
//ShowArray(arr);
//ChangeValue(number, arr, ref number, out number2);
//Console.WriteLine("After call method:");
//Console.WriteLine($"number = {number}, number2 = {number2}"); // 56 
//ShowArray(arr);

//SomeMethod(out int myVar);
//Console.WriteLine(myVar);

//void ChangeValue(int number, int[] arr, ref int numb1, out int numb2)
//{
//    number += 48;
//    arr[0] = number;
//    numb1++;
//    numb2 = 15;
//}

//string numb = "25";
//MyTryParse(numb, out int number);
//int num;
//MyTryParse("numb", out num);
//Console.WriteLine(number);
//Console.WriteLine(num);

//void SomeMethod(out int number)
//{
//    number = 13;
//}

//void ShowArray(int[] arr)
//{
//    foreach(int i in arr)
//    {
//        Console.Write($"{i} ");
//    }
//    Console.WriteLine();
//}


//bool MyTryParse(string value, out int outValue)
//{
//	try
//	{
//		outValue = int.Parse(value);
//        return true;
//    }
//	catch 
//	{
//		outValue = default;
//		return false;
//	}
//}