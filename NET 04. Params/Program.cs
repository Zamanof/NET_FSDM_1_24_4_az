// params - metoda "Sonsuz" sayda parametrlərin göndərilməsi
int[] arr = [23, 65, 1, 2, 115, 45];
Console.WriteLine(Summ(arr));
Console.WriteLine(Summ(new int[] { 23, 65, 1, 2, 115, 45 }));
Console.WriteLine(SummParams(23, 65, 1, 2, 115, 45, 78, 78, 9911, 165));
Console.WriteLine(SummParams(arr));

int Summ(int[] ints)
{
    int result = 0;
    foreach (int i in ints)
    {
        result += i;
    }
    return result;
}

int SummParams(params int[] ints)
{
    int result = 0;
    foreach (int i in ints)
    {
        result += i;
    }
    return result;
}
