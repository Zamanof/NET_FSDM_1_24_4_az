//int [] arr = new int[2] { 2, 6};
//Console.WriteLine(arr[0]);

//int[] ints = [5, 9, 78, 54];
//Console.WriteLine(ints.Length);
//Console.WriteLine(ints.Rank);

Random random = new Random();
//int[,] multArr = new int[2, 2] { { 2, 89 }, { 36, 45 } };
//Console.WriteLine(multArr.Rank);
//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        multArr[i, j] = random.Next(10, 99);
//    }
//}

//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        Console.Write($"{multArr[i, j]} ");
//    }

//    Console.WriteLine();
//}

//Console.WriteLine(multArr[0, 0]);


// jagged array
int[][] jArr = new int[3][];
jArr[0] = new int[3];
jArr[1] = new int[4];
jArr[2] = new int[1];

for (int i = 0; i < jArr.Length; i++)
{
    for (int j = 0; j < jArr[i].Length; j++)
    {
        jArr[i][j] = random.Next(10, 99);
    }
}

for (int i = 0; i < jArr.Length; i++)
{
    for (int j = 0; j < jArr[i].Length; j++)
    {
        Console.Write($"{jArr[i][j]} "); 
    }
    Console.WriteLine();
}


